using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager
{
    public partial class Form1 : Form
    {
        private BusinessRules br;
        private OpenFileDialog _openDialog = new OpenFileDialog();
        private Book currentBook = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("First select the file where information is stored");
            br = BusinessRules.GetInstance();
            //prompt to open file
            _openDialog.Filter = "Binary Files *.bin|*.bin|Serialized Path *.ser|*.ser";
            _openDialog.FilterIndex = 1;
            if (_openDialog.ShowDialog() == DialogResult.OK)
            {
                br.filePath = _openDialog.FileName;
                br.readFromDiskFile();
            }
            else
            {
                this.Close();
            }
            dat_todaysDate.Value = br.currentDate;
            br.checkDatesOfCheckedOutBooks();
        }

        private void btn_books_Click(object sender, EventArgs e)
        {
            hideMainMenu();
            showBooksMenu();
        }

        private void showBooksMenu()
        {
            dataGrid_books.Visible = true;
            btn_manage.Visible = true;
            btn_sortByName.Visible = true;
            btn_goBackBooks.Visible = true;
            //display all books in the dataGridView
            //load tables
            dataGrid_books.Rows.Clear();
            foreach (Book book in br.Books)
            {
                string[] row = null;
                if (book.BookStatus == Library_Manager.Status.Available)
                {
                    string[] tmprow = { book.ID.ToString(), book.Name, book.Type.ToString(), book.BookStatus.ToString(), "" };
                    row = tmprow;
                }
                else
                {
                    string[] tmprow = { book.ID.ToString(), book.Name, book.Type.ToString(), book.BookStatus.ToString(), book.CheckoutDate.ToString() };
                    row = tmprow;
                }
                dataGrid_books.Rows.Add(row);
            }
        }

        private void hideMainMenu()
        {
            btn_books.Visible = false;
            btn_addBook.Visible = false;
            btn_patrons.Visible = false;
        }

        private void showMainMenu()
        {
            btn_books.Visible = true;
            btn_addBook.Visible = true;
            btn_patrons.Visible = true;
        }

        private void hideBooksMenu()
        {
            dataGrid_books.Visible = false;
            btn_manage.Visible = false;
            btn_sortByName.Visible = false;
            btn_goBackBooks.Visible = false;
        }

        private void showManageMenu()
        {
            lbl_currentStatus.Visible = true;
            lbl_currentStatusDYNAMIC.Visible = true;
            btn_cancel.Visible = true;
            btn_checkin.Visible = true;
            btn_checkout.Visible = true;
            lbl_currentStatusDYNAMIC.Text = currentBook.BookStatus.ToString();
            lbl_selectAuser.Visible = true;
            drp_patronsIds.Visible = true;
            dat_bookDateCheckedOut.Visible = true;
            drp_patronsIds.Items.Clear();
            drp_patronsIds.Text = "Select One";
            foreach (Patron p in br.Patrons)
            {
                drp_patronsIds.Items.Add(p.ID);
            }
        }

        private void showPatronsMenu()
        {
            dataGrid_patrons.Visible = true;
            btn_addPatron.Visible = true;
            btn_seePatronBooks.Visible = true;
            btn_goBackPatrons.Visible = true;
            dataGrid_patrons.Rows.Clear();
            foreach (Patron patron in br.Patrons)
            {
                string[] row = { patron.ID.ToString(), patron.LastName, patron.MidInit, patron.FirstName, patron.Books.Count.ToString(), patron.OverdueBooks.Count.ToString(), patron.PatronType, patron.PhoneNumber };
                dataGrid_patrons.Rows.Add(row);
            }
        }

        private void hidePatronsMenu()
        {
            dataGrid_patrons.Visible = false;
            btn_addPatron.Visible = false;
            btn_seePatronBooks.Visible = false;
            btn_goBackPatrons.Visible = false;
        }

        private void hideManageMenu() 
        {
            lbl_currentStatus.Visible = false;
            lbl_currentStatusDYNAMIC.Visible = false;
            btn_cancel.Visible = false;
            lbl_selectAuser.Visible = false;
            drp_patronsIds.Visible = false;
            dat_bookDateCheckedOut.Visible = false;
            btn_checkin.Visible = false;
            btn_checkout.Visible = false;
        }

        private void btn_goBackBooks_Click(object sender, EventArgs e)
        {
            hideBooksMenu();
            showMainMenu();
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            hideBooksMenu();
            DataGridViewRow row = this.dataGrid_books.Rows[dataGrid_books.CurrentRow.Index];
            uint currentBookId = uint.Parse(row.Cells["ID"].Value.ToString());
            currentBook = br.getBook(currentBookId);
            showManageMenu();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            hideManageMenu();
            showBooksMenu();
        }

        private void btn_sortByName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented yet");

        }

        private void btn_addBookMenu_Click(object sender, EventArgs e)
        {
            string bookName = tbx_bookName.Text;
            string bookType = drp_addBookType.Text;
            string bookId = tbx_bookID.Text;
            bool allOK = true;
            //validate with business rules
            if (!br.BookName_validator(bookName)) 
            { 
                allOK = false;
                lbl_errorAddBookName.Visible = true;
                MessageBox.Show("Invalid book name. This field cannot be empty and must be less than 40 characters.");
            }
            else
            {
                lbl_errorAddBookName.Visible = false;
            }

            if (allOK && !br.BookType_validator(bookType))
            {
                allOK = false;
                lbl_errorDropAddBook.Visible = true;
                MessageBox.Show("Invalid book type. Please select a valid book type.");
            }
            else
            {
                lbl_errorDropAddBook.Visible = false;
            }

            if (allOK && !br.BookId_validator(bookId))
            {
                allOK = false;
                lbl_errorBookID.Visible = true;
                MessageBox.Show("Invalid book ID. Make sure no other book has the same ID, must be 5 digits, numbers only.");
            }
            else
            {
                lbl_errorBookID.Visible = false;
            }

            if (allOK)
            {
                BookType bt;
                if (bookType == br.ADULT)
                    bt = BookType.AdultBook;
                else if (bookType == br.CHILDREN)
                    bt = BookType.ChildrenBook;
                else if (bookType == br.DVD)
                    bt = BookType.DVD;
                else
                    bt = BookType.Videotape;

                Book book = new Book(uint.Parse(bookId), bookName, Library_Manager.Status.Available, bt);
                br.Books.Add(book);

                string[] row = { book.ID.ToString(), book.Name, book.Type.ToString(), book.BookStatus.ToString()};
                dataGrid_books.Rows.Add(row);
                MessageBox.Show("Book added successfully");
                showAddBookMenu();
            }

        }

        private void showAddBookMenu()
        {
            tbx_bookID.Clear();
            tbx_bookName.Clear();
            drp_addBookType.Text = "Select One";
            tbx_bookName.Clear();
            lbl_bookName.Visible = true;
            tbx_bookName.Visible = true;
            lbl_bookId.Visible = true;
            tbx_bookID.Visible = true;
            drp_addBookType.Visible = true;
            btn_addBookMenu.Visible = true;
            btn_cancelBookMenu.Visible = true;
        }

        private void hideAddBookMenu()
        {
            lbl_bookName.Visible = false;
            tbx_bookName.Visible = false;
            drp_addBookType.Visible = false;
            btn_addBookMenu.Visible = false;
            btn_cancelBookMenu.Visible = false;
            lbl_errorAddBookName.Visible = false;
            lbl_errorDropAddBook.Visible = false;
            lbl_errorBookID.Visible = false;
            lbl_bookId.Visible = false;
            tbx_bookID.Visible = false;
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            hideMainMenu();
            showAddBookMenu();
        }

        private void btn_cancelBookMenu_Click(object sender, EventArgs e)
        {
            hideAddBookMenu();
            showMainMenu();
        }

        private void btn_goBackPatrons_Click(object sender, EventArgs e)
        {
            hidePatronsMenu();
            showMainMenu();
        }

        private void showAddPatronMenu()
        {
            lbl_patronFirstName.Visible = true;
            lbl_patronId.Visible = true;
            lbl_LastName.Visible = true;
            lbl_mInit.Visible = true;
            lbl_phoneNumber.Visible = true;
            drp_patronType.Text = "Select One";
            drp_patronType.Visible = true;
            btn_addPatronToDB.Visible = true;
            btn_cancelPatron.Visible = true;
            tbx_patronFirstName.Clear();
            tbx_patronId.Clear();
            tbx_patronLastName.Clear();
            tbx_patronMinit.Clear();
            tbx_phoneNumber.Clear();
            tbx_patronFirstName.Visible = true;
            tbx_patronId.Visible = true;
            tbx_patronLastName.Visible = true;
            tbx_patronMinit.Visible = true;
            tbx_phoneNumber.Visible = true;
        }

        private void hideAddPatronMenu()
        {
            lbl_patronFirstName.Visible = false;
            lbl_patronId.Visible = false;
            lbl_LastName.Visible = false;
            lbl_mInit.Visible = false;
            lbl_phoneNumber.Visible = false;
            drp_patronType.Visible = false;
            btn_addPatronToDB.Visible = false;
            btn_cancelPatron.Visible = false;
            lbl_errorId.Visible = false;
            lbl_errorLastName.Visible = false;
            lbl_errorMiddleInit.Visible = false;
            lbl_errorPatronType.Visible = false;
            lbl_errorPhoneNumber.Visible = false;
            lbl_patronFirstName.Visible = false;
            tbx_patronFirstName.Visible = false;
            tbx_patronId.Visible = false;
            tbx_patronLastName.Visible = false;
            tbx_patronMinit.Visible = false;
            tbx_phoneNumber.Visible = false;
        }

        private void btn_cancelPatron_Click(object sender, EventArgs e)
        {
            hideAddPatronMenu();
            showPatronsMenu();
        }

        private void btn_patrons_Click(object sender, EventArgs e)
        {
            hideMainMenu();
            showPatronsMenu();
        }

        private void btn_addPatron_Click(object sender, EventArgs e)
        {
            showAddPatronMenu();
            hidePatronsMenu();
        }

        private void btn_addPatronToDB_Click(object sender, EventArgs e)
        {
            //get
            string id = tbx_patronId.Text;
            string firstName = tbx_patronFirstName.Text;
            string lastName = tbx_patronLastName.Text;
            string midInit = tbx_patronMinit.Text;
            string phoneNumber = tbx_phoneNumber.Text;
            string patronType = drp_patronType.Text;

            bool allOk = true;
            //validation

            //validate id
            if (!br.PatronId_validator(id))
            {
                allOk = false;
                lbl_errorId.Visible = true;
                MessageBox.Show("Invalid ID. Make sure Id is unique from other patrons in database. Id should be 5 digits.");
            }
            else
            {
                lbl_errorId.Visible = false;
            }

            //validate first name
            if (allOk && !br.name_validator(firstName))
            {
                allOk = false;
                lbl_errorName.Visible = true;
                MessageBox.Show("Invalid First Name.");
            }
            else
            {
                lbl_errorName.Visible = false;
            }

            //validate last name
            if (allOk && !br.name_validator(lastName))
            {
                allOk = false;
                lbl_errorLastName.Visible = true;
                MessageBox.Show("Invalid Last Name.");
            }
            else
            {
                lbl_errorLastName.Visible = false;
            }

            //validate middle name initial
            if (allOk && !br.middleName_validator(midInit))
            {
                allOk = false;
                lbl_errorMiddleInit.Visible = true;
                MessageBox.Show("Invalid Middle Name. Only Initial required");
            }
            else
            {
                lbl_errorMiddleInit.Visible = false;
            }

            //validate phone number
            if (allOk && !br.phoneNumber_validator(phoneNumber))
            {
                allOk = false;
                lbl_errorPhoneNumber.Visible = true;
                MessageBox.Show("Invalid phone number. Only digits and '-' allowed");
            }
            else
            {
                lbl_errorPhoneNumber.Visible = false;
            }

            //validate patron type
            if (allOk && !br.patronType_validator(patronType))
            {
                allOk = false;
                lbl_errorPatronType.Visible = true;
                MessageBox.Show("Invalid patron type. Please select one.");
            }
            else
            {
                lbl_errorPatronType.Visible = false;
            }

            //save
            if (allOk)
            {
                Patron patron = new Patron(uint.Parse(id), lastName, midInit, firstName, phoneNumber, patronType);
                br.Patrons.Add(patron);

                string[] row = { patron.ID.ToString(), patron.LastName, patron.MidInit, patron.FirstName, patron.Books.Count.ToString(), patron.OverdueBooks.Count.ToString(), patron.PatronType, patron.PhoneNumber };
                dataGrid_patrons.Rows.Add(row);
                MessageBox.Show("Patron added successfully");
                showAddPatronMenu();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            br.writeToDiskFile();
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            br.writeToDiskFile();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            bool allOk = true;
            //validate
            if (drp_patronsIds.Text == "Select One")
            {
                allOk = false;
                MessageBox.Show("Please Select a Patron ID, it is required");
            }
            if (allOk == true)
            {
                dat_bookDateCheckedOut.Value = dat_todaysDate.Value;
                Patron patron = br.getPatron(uint.Parse(drp_patronsIds.Text));
                string message = br.validate_checkout(patron, currentBook);

                if (message == "success")
                {
                    br.checkout(patron,currentBook,dat_bookDateCheckedOut.Value);
                    MessageBox.Show("Book checked out successfully");
                    hideManageMenu();
                    showBooksMenu();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }

        private void btn_updateDate_Click(object sender, EventArgs e)
        {
            btn_updateDate.Visible = false;
            dat_todaysDate.Enabled = false;
            br.currentDate = dat_todaysDate.Value;

            //update tables and data
            br.checkDatesOfCheckedOutBooks();
            dataGrid_patrons.Rows.Clear();
            foreach (Patron patron in br.Patrons)
            {
                string[] row = { patron.ID.ToString(), patron.LastName, patron.MidInit, patron.FirstName, patron.Books.Count.ToString(), patron.OverdueBooks.Count.ToString(), patron.PatronType, patron.PhoneNumber };
                dataGrid_patrons.Rows.Add(row);
            }
            dataGrid_books.Rows.Clear();
            foreach (Book book in br.Books)
            {
                string[] row = null;
                if (book.BookStatus == Library_Manager.Status.Available)
                {
                    string[] tmprow = { book.ID.ToString(), book.Name, book.Type.ToString(), book.BookStatus.ToString(), "" };
                    row = tmprow;
                }
                else
                {
                    string[] tmprow = { book.ID.ToString(), book.Name, book.Type.ToString(), book.BookStatus.ToString(), book.CheckoutDate.ToString() };
                    row = tmprow;
                }
                dataGrid_books.Rows.Add(row);
            }
        }

        private void changeTodaysDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change the date and then click Update button");
            dat_todaysDate.Enabled = true;
            btn_updateDate.Visible = true;
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            if (currentBook.BookStatus != Library_Manager.Status.Available)
            {
                br.checkin(currentBook);
                MessageBox.Show("Book checked in successfully");
                hideManageMenu();
                showBooksMenu();
            }
            else
            {
                MessageBox.Show("Book is already Available");
            }
        }

        private void btn_seePatronBooks_Click(object sender, EventArgs e)
        {
            hidePatronsMenu();

            DataGridViewRow patronRow = this.dataGrid_patrons.Rows[dataGrid_patrons.CurrentRow.Index];
            uint currentPatronId = uint.Parse(patronRow.Cells["patronID"].Value.ToString());
            Patron currentPatron = br.getPatron(currentPatronId);
            lbl_patronRecord.Visible = true;
            lbl_patronRecord.Text = "ID: " + currentPatron.ID + ", Name: " + currentPatron.FirstName + " " + currentPatron.MidInit + " " + currentPatron.LastName;
            dataGrid_books.Rows.Clear();
            foreach (Book book in currentPatron.Books)
            {
                string[] row = null;
                if (book.BookStatus == Library_Manager.Status.Available)
                {
                    string[] tmprow = { book.ID.ToString(), book.Name, book.Type.ToString(), book.BookStatus.ToString(), "" };
                    row = tmprow;
                }
                else
                {
                    string[] tmprow = { book.ID.ToString(), book.Name, book.Type.ToString(), book.BookStatus.ToString(), book.CheckoutDate.ToString() };
                    row = tmprow;
                }
                dataGrid_books.Rows.Add(row);
            }
            dataGrid_books.Visible = true;
            btn_goBackSeePatronsBooks.Visible = true;
        }//end btn_seePatronBooks_Click

        private void btn_goBackSeePatronsBooks_Click(object sender, EventArgs e)
        {
            btn_goBackSeePatronsBooks.Visible = false;
            lbl_patronRecord.Visible = false;
            dataGrid_books.Visible = false;
            showPatronsMenu();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Library Manager Project\nMade by the C# team\nCS2450\nSUMMER 2015");
        }
    }//end class Form1
}//end namespace
