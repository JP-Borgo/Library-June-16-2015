using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Library_Manager
{
    class BusinessRules
    {
        private static BusinessRules businessRules = null;
        private FileIO myFile;
        public string ADULT = "Adult Book", CHILDREN = "Children Book", DVD = "DVD", VIDEOTAPE = "Videotape";
        public string ADULT_PATRON = "Adult", CHILDREN_PATRON = "Children";
        public List<Book> Books;
        public List<Patron> Patrons;
        public string filePath = null;
        public DateTime currentDate;

        private BusinessRules()
        {
            Books = new List<Book>();
            Patrons = new List<Patron>();
            myFile = new FileIO();
        }

        public static BusinessRules GetInstance()
        {
            if (businessRules == null)
            {
                businessRules = new BusinessRules();
            }
            return businessRules;
        }

        public bool BookName_validator(string bookName)
        {
            Regex _validator = new Regex(@"^[a-zA-Z0-9 -'\.\,]+$");
            bookName = (bookName ?? string.Empty);
            if (bookName.Length > 40)
                return false;
            return _validator.IsMatch(bookName);
        }

        public bool BookType_validator(string bookType)
        {
            if (bookType == ADULT || bookType == CHILDREN || bookType == DVD || bookType == VIDEOTAPE)
                return true;
            else
                return false;
        }

        public bool BookId_validator(string bookId) 
        {
            Regex _validator = new Regex("^[0-9]+$");
            bookId = (bookId ?? string.Empty);
            if (bookId.Length != 5)
                return false;
            foreach (Book b in Books)
            {
                if (b.ID == uint.Parse(bookId))
                    return false;
            }
            return _validator.IsMatch(bookId);
        }

        public bool PatronId_validator(string patronId)
        {
            Regex _validator = new Regex("^[0-9]+$");
            patronId = (patronId ?? string.Empty);
            if (patronId.Length != 5)
                return false;
            foreach (Patron p in Patrons)
            {
                if (p.ID ==  uint.Parse(patronId))
                    return false;
            }
            return _validator.IsMatch(patronId);
        }

        /// <summary>
        /// Purpose: Regex to validate First Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool name_validator(string input)
        {
            Regex _validator = new Regex("^[a-zA-Z-']+$");
            input = (input ?? string.Empty);
            if (input.Length > 30)
                return false;
            return _validator.IsMatch(input);
        }

        /// <summary>
        /// Purpose: Regex to validate Middle Name Initial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool middleName_validator(string input)
        {
            Regex _validator = new Regex("^[A-Z]*$");
            input = (input ?? string.Empty);
            if (input.Length > 1)
                return false;
            return _validator.IsMatch(input);
        }

        /// <summary>
        /// Purpose: Regex to validate Phone Number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool phoneNumber_validator(string input)
        {
            Regex _validator = new Regex("^[0-9-]+$");
            input = (input ?? string.Empty);
            if (input.Length > 15)
                return false;
            return _validator.IsMatch(input);
        }

        public bool patronType_validator(string patronType)
        {
            if (patronType == ADULT_PATRON || patronType == CHILDREN_PATRON)
                return true;
            else return false;
        }

        /// <summary>
        ///  Puspose: Allow the the user open the file.
        ///     Makes use of FileIO class which serializes and deserializes the data contained within the
        ///     sorted-directory.
        /// </summary>
        /// <param name="fileName"></param>
        public void readFromDiskFile()
        {
            myFile.setFilePath(filePath);
            myFile.openDB();
            myFile.readDB();
            LibraryData ld = myFile.DB;
            Books = ld.Books;
            Patrons = ld.Patrons;
            if (ld.CurrentDate == default(DateTime))
                ld.CurrentDate = DateTime.Now;
            currentDate = ld.CurrentDate;
        }
        /// <summary>
        ///  Puspose: Allows the the user save the file.
        ///     Makes use of FileIO class which serializes and deserializes the data contained within the
        ///     sorted-directory.
        /// </summary>
        /// <param name="fileName"></param>
        public void writeToDiskFile()
        {
            myFile.setFilePath(filePath);
            myFile.openDB();
            LibraryData ld = myFile.DB;
            ld.Books = Books;
            ld.Patrons = Patrons;
            ld.CurrentDate = currentDate;
            myFile.DB = ld;
            myFile.writeDB();
        }

        public Book getBook(uint id)
        {
            Book targetBook = null;
            foreach (Book book in Books) 
            {
                if (book.ID == id)
                {
                    targetBook = book;
                    break;
                }
            }
            return targetBook;
        }

        public Patron getPatron(uint id)
        {
            Patron targetPatron = null;
            foreach (Patron patron in Patrons)
            {
                if (patron.ID == id)
                {
                    targetPatron = patron;
                    break;
                }
            }
            return targetPatron;
        }

        public string validate_checkout(Patron patron, Book book)
        {
            string message = "success";
            if (patron.PatronType == CHILDREN_PATRON && book.Type == BookType.AdultBook)
                message = "Error: children cannot checkout adult books";
            else if (patron.PatronType == ADULT_PATRON && patron.Books.Count >= 6)
                message = "Error: patron has reach maximum checkout limit";
            else if (patron.PatronType == CHILDREN_PATRON && patron.Books.Count >= 3)
                message = "Error: patron has reach maximum checkout limit";
            else if (book.BookStatus == Status.CheckedOut || book.BookStatus == Status.Overdue)
                message = "Error: the book '" + book.Name + "' is not available";

            return message;
        }

        public void checkout(Patron patron, Book book, DateTime dt) 
        {
            //change status and add date tiem
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].ID == book.ID)
                {
                    Books[i].CheckoutDate = dt;
                    Books[i].BookStatus = Status.CheckedOut;
                    break;
                }
            }
            //add book to patron
            for (int i = 0; i < Patrons.Count; i++)
            {
                if (Patrons[i].ID == patron.ID)
                {
                    Patrons[i].Books.Add(book);
                    break;
                }
            }
        }//end checkout

        public void checkin(Book book)
        {
            //change status of book to available
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].ID == book.ID)
                {
                    Books[i].BookStatus = Status.Available;
                    break;
                }
            }
            //remove book from patron (in boths lists, Books and OverdueBooks)
            for (int i = 0; i < Patrons.Count; i++)
            {
                if (Patrons[i].Books.Count > 0)
                {
                    for (int j = 0; j < Patrons[i].Books.Count; j++)
                    {
                        if (Patrons[i].Books[j].ID == book.ID)
                        {
                            Patrons[i].Books.RemoveAt(j);
                        }
                    }
                }
                if (Patrons[i].OverdueBooks.Count > 0)
                {
                    for (int j = 0; j < Patrons[i].OverdueBooks.Count; j++)
                    {
                        if (Patrons[i].OverdueBooks[j].ID == book.ID)
                        {
                            Patrons[i].OverdueBooks.RemoveAt(j);
                        }
                    }
                }
            }
        }//end checkin

        public void checkDatesOfCheckedOutBooks()
        {
            int difference = 0;
            
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].BookStatus == Status.CheckedOut)
                {
                    difference = currentDate.Subtract(Books[i].CheckoutDate).Days;
                    if (Books[i].Type == BookType.AdultBook && difference > 14)
                    {
                        Books[i].BookStatus = Status.Overdue;
                        updateOverduePatronsBooks(Books[i]);
                    }
                    else if (Books[i].Type == BookType.ChildrenBook && difference > 7)
                    {
                        Books[i].BookStatus = Status.Overdue;
                        updateOverduePatronsBooks(Books[i]);
                    }
                    else if (Books[i].Type == BookType.DVD && difference > 2)
                    {
                        Books[i].BookStatus = Status.Overdue;
                        updateOverduePatronsBooks(Books[i]);
                    }
                    else if (Books[i].Type == BookType.Videotape && difference > 3)
                    {
                        Books[i].BookStatus = Status.Overdue;
                        updateOverduePatronsBooks(Books[i]);
                    }
                }//end if
            }///end for loop
        }//end checkDatesOfCheckedOutBooks

        private void updateOverduePatronsBooks(Book book)
        {
            //find the owner of book
            for (int i = 0; i < Patrons.Count; i++)
            {
                if (Patrons[i].Books.Count > 0)
                {
                    for (int j = 0; i < Books.Count; j++)
                    {
                        if (Patrons[i].Books[j].ID == book.ID)
                        {
                            //if the status changed, change the status of the book and also add it to the overdue books if needed
                            if (book.BookStatus == Status.Overdue)
                            {
                                Patrons[i].Books[j].BookStatus = Status.Overdue;
                                Patrons[i].OverdueBooks.Add(book);
                                return;
                            }
                        }
                    }
                }
            }
        }//end updateOverduePatronsBooks
    }//end class
}
