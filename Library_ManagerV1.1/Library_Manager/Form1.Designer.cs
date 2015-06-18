namespace Library_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_changeTodaysTools = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTodaysDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_books = new System.Windows.Forms.Button();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.btn_patrons = new System.Windows.Forms.Button();
            this.dataGrid_books = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_manage = new System.Windows.Forms.Button();
            this.btn_sortByName = new System.Windows.Forms.Button();
            this.btn_goBackBooks = new System.Windows.Forms.Button();
            this.lbl_currentStatus = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_bookName = new System.Windows.Forms.Label();
            this.tbx_bookName = new System.Windows.Forms.TextBox();
            this.drp_addBookType = new System.Windows.Forms.ComboBox();
            this.btn_addBookMenu = new System.Windows.Forms.Button();
            this.btn_cancelBookMenu = new System.Windows.Forms.Button();
            this.lbl_errorAddBookName = new System.Windows.Forms.Label();
            this.lbl_errorDropAddBook = new System.Windows.Forms.Label();
            this.dataGrid_patrons = new System.Windows.Forms.DataGridView();
            this.patronId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronMinit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedOutBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronsOverdueBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_seePatronBooks = new System.Windows.Forms.Button();
            this.btn_addPatron = new System.Windows.Forms.Button();
            this.btn_goBackPatrons = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbx_patronId = new System.Windows.Forms.TextBox();
            this.lbl_patronId = new System.Windows.Forms.Label();
            this.tbx_patronFirstName = new System.Windows.Forms.TextBox();
            this.tbx_patronMinit = new System.Windows.Forms.TextBox();
            this.lbl_mInit = new System.Windows.Forms.Label();
            this.tbx_patronLastName = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.drp_patronType = new System.Windows.Forms.ComboBox();
            this.lbl_patronFirstName = new System.Windows.Forms.Label();
            this.lbl_errorId = new System.Windows.Forms.Label();
            this.lbl_errorName = new System.Windows.Forms.Label();
            this.lbl_errorMiddleInit = new System.Windows.Forms.Label();
            this.lbl_errorLastName = new System.Windows.Forms.Label();
            this.lbl_errorPatronType = new System.Windows.Forms.Label();
            this.tbx_phoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_errorPhoneNumber = new System.Windows.Forms.Label();
            this.btn_addPatronToDB = new System.Windows.Forms.Button();
            this.btn_cancelPatron = new System.Windows.Forms.Button();
            this.lbl_bookId = new System.Windows.Forms.Label();
            this.tbx_bookID = new System.Windows.Forms.TextBox();
            this.lbl_errorBookID = new System.Windows.Forms.Label();
            this.drp_patronsIds = new System.Windows.Forms.ComboBox();
            this.lbl_selectAuser = new System.Windows.Forms.Label();
            this.dat_bookDateCheckedOut = new System.Windows.Forms.DateTimePicker();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.lbl_currentStatusDYNAMIC = new System.Windows.Forms.Label();
            this.btn_checkin = new System.Windows.Forms.Button();
            this.dat_todaysDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_todaysdate = new System.Windows.Forms.Label();
            this.btn_updateDate = new System.Windows.Forms.Button();
            this.btn_goBackSeePatronsBooks = new System.Windows.Forms.Button();
            this.lbl_patronRecord = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_patrons)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.menu_changeTodaysTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(119, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menu_changeTodaysTools
            // 
            this.menu_changeTodaysTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTodaysDateToolStripMenuItem});
            this.menu_changeTodaysTools.Name = "menu_changeTodaysTools";
            this.menu_changeTodaysTools.Size = new System.Drawing.Size(57, 24);
            this.menu_changeTodaysTools.Text = "Tools";
            // 
            // changeTodaysDateToolStripMenuItem
            // 
            this.changeTodaysDateToolStripMenuItem.Name = "changeTodaysDateToolStripMenuItem";
            this.changeTodaysDateToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.changeTodaysDateToolStripMenuItem.Text = "Change Today\'s Date";
            this.changeTodaysDateToolStripMenuItem.Click += new System.EventHandler(this.changeTodaysDateToolStripMenuItem_Click);
            // 
            // btn_books
            // 
            this.btn_books.Location = new System.Drawing.Point(399, 173);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(270, 69);
            this.btn_books.TabIndex = 1;
            this.btn_books.Text = "Books";
            this.btn_books.UseVisualStyleBackColor = true;
            this.btn_books.Click += new System.EventHandler(this.btn_books_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(399, 268);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(270, 69);
            this.btn_addBook.TabIndex = 1;
            this.btn_addBook.Text = "Add Book";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // btn_patrons
            // 
            this.btn_patrons.Location = new System.Drawing.Point(399, 361);
            this.btn_patrons.Name = "btn_patrons";
            this.btn_patrons.Size = new System.Drawing.Size(270, 69);
            this.btn_patrons.TabIndex = 1;
            this.btn_patrons.Text = "Patrons";
            this.btn_patrons.UseVisualStyleBackColor = true;
            this.btn_patrons.Click += new System.EventHandler(this.btn_patrons_Click);
            // 
            // dataGrid_books
            // 
            this.dataGrid_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.bookName,
            this.Book_Type,
            this.Status,
            this.CheckoutDate});
            this.dataGrid_books.Location = new System.Drawing.Point(30, 95);
            this.dataGrid_books.Name = "dataGrid_books";
            this.dataGrid_books.RowTemplate.Height = 24;
            this.dataGrid_books.Size = new System.Drawing.Size(1033, 356);
            this.dataGrid_books.TabIndex = 2;
            this.dataGrid_books.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Name";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Width = 170;
            // 
            // Book_Type
            // 
            this.Book_Type.HeaderText = "Book Type";
            this.Book_Type.Name = "Book_Type";
            this.Book_Type.ReadOnly = true;
            this.Book_Type.Width = 170;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 170;
            // 
            // CheckoutDate
            // 
            this.CheckoutDate.HeaderText = "Checkout Date";
            this.CheckoutDate.Name = "CheckoutDate";
            this.CheckoutDate.ReadOnly = true;
            this.CheckoutDate.Width = 170;
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(264, 457);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(163, 39);
            this.btn_manage.TabIndex = 3;
            this.btn_manage.Text = "Manage Selected";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Visible = false;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // btn_sortByName
            // 
            this.btn_sortByName.Location = new System.Drawing.Point(421, 457);
            this.btn_sortByName.Name = "btn_sortByName";
            this.btn_sortByName.Size = new System.Drawing.Size(172, 39);
            this.btn_sortByName.TabIndex = 3;
            this.btn_sortByName.Text = "Sort by Name";
            this.btn_sortByName.UseVisualStyleBackColor = true;
            this.btn_sortByName.Visible = false;
            this.btn_sortByName.Click += new System.EventHandler(this.btn_sortByName_Click);
            // 
            // btn_goBackBooks
            // 
            this.btn_goBackBooks.Location = new System.Drawing.Point(590, 457);
            this.btn_goBackBooks.Name = "btn_goBackBooks";
            this.btn_goBackBooks.Size = new System.Drawing.Size(173, 39);
            this.btn_goBackBooks.TabIndex = 3;
            this.btn_goBackBooks.Text = "Go Back";
            this.btn_goBackBooks.UseVisualStyleBackColor = true;
            this.btn_goBackBooks.Visible = false;
            this.btn_goBackBooks.Click += new System.EventHandler(this.btn_goBackBooks_Click);
            // 
            // lbl_currentStatus
            // 
            this.lbl_currentStatus.AutoSize = true;
            this.lbl_currentStatus.Location = new System.Drawing.Point(404, 223);
            this.lbl_currentStatus.Name = "lbl_currentStatus";
            this.lbl_currentStatus.Size = new System.Drawing.Size(99, 17);
            this.lbl_currentStatus.TabIndex = 5;
            this.lbl_currentStatus.Text = "current status:";
            this.lbl_currentStatus.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(573, 331);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_bookName
            // 
            this.lbl_bookName.AutoSize = true;
            this.lbl_bookName.Location = new System.Drawing.Point(404, 279);
            this.lbl_bookName.Name = "lbl_bookName";
            this.lbl_bookName.Size = new System.Drawing.Size(81, 17);
            this.lbl_bookName.TabIndex = 8;
            this.lbl_bookName.Text = "Book Name";
            this.lbl_bookName.Visible = false;
            // 
            // tbx_bookName
            // 
            this.tbx_bookName.Location = new System.Drawing.Point(491, 279);
            this.tbx_bookName.Name = "tbx_bookName";
            this.tbx_bookName.Size = new System.Drawing.Size(157, 22);
            this.tbx_bookName.TabIndex = 10;
            this.tbx_bookName.Visible = false;
            // 
            // drp_addBookType
            // 
            this.drp_addBookType.FormattingEnabled = true;
            this.drp_addBookType.Items.AddRange(new object[] {
            "Adult Book",
            "Children Book",
            "DVD",
            "Videotape"});
            this.drp_addBookType.Location = new System.Drawing.Point(491, 307);
            this.drp_addBookType.Name = "drp_addBookType";
            this.drp_addBookType.Size = new System.Drawing.Size(157, 24);
            this.drp_addBookType.TabIndex = 11;
            this.drp_addBookType.Visible = false;
            // 
            // btn_addBookMenu
            // 
            this.btn_addBookMenu.Location = new System.Drawing.Point(491, 337);
            this.btn_addBookMenu.Name = "btn_addBookMenu";
            this.btn_addBookMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_addBookMenu.TabIndex = 12;
            this.btn_addBookMenu.Text = "Add";
            this.btn_addBookMenu.UseVisualStyleBackColor = true;
            this.btn_addBookMenu.Visible = false;
            this.btn_addBookMenu.Click += new System.EventHandler(this.btn_addBookMenu_Click);
            // 
            // btn_cancelBookMenu
            // 
            this.btn_cancelBookMenu.Location = new System.Drawing.Point(573, 337);
            this.btn_cancelBookMenu.Name = "btn_cancelBookMenu";
            this.btn_cancelBookMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelBookMenu.TabIndex = 12;
            this.btn_cancelBookMenu.Text = "Cancel";
            this.btn_cancelBookMenu.UseVisualStyleBackColor = true;
            this.btn_cancelBookMenu.Visible = false;
            this.btn_cancelBookMenu.Click += new System.EventHandler(this.btn_cancelBookMenu_Click);
            // 
            // lbl_errorAddBookName
            // 
            this.lbl_errorAddBookName.AutoSize = true;
            this.lbl_errorAddBookName.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorAddBookName.Location = new System.Drawing.Point(654, 279);
            this.lbl_errorAddBookName.Name = "lbl_errorAddBookName";
            this.lbl_errorAddBookName.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorAddBookName.TabIndex = 12;
            this.lbl_errorAddBookName.Text = "*";
            this.lbl_errorAddBookName.Visible = false;
            // 
            // lbl_errorDropAddBook
            // 
            this.lbl_errorDropAddBook.AutoSize = true;
            this.lbl_errorDropAddBook.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorDropAddBook.Location = new System.Drawing.Point(654, 305);
            this.lbl_errorDropAddBook.Name = "lbl_errorDropAddBook";
            this.lbl_errorDropAddBook.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorDropAddBook.TabIndex = 12;
            this.lbl_errorDropAddBook.Text = "*";
            this.lbl_errorDropAddBook.Visible = false;
            // 
            // dataGrid_patrons
            // 
            this.dataGrid_patrons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_patrons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patronId,
            this.patronLastName,
            this.patronMinit,
            this.patronFirstName,
            this.CheckedOutBooks,
            this.patronsOverdueBooks,
            this.patronType,
            this.phoneNumber});
            this.dataGrid_patrons.Location = new System.Drawing.Point(30, 95);
            this.dataGrid_patrons.Name = "dataGrid_patrons";
            this.dataGrid_patrons.ReadOnly = true;
            this.dataGrid_patrons.RowTemplate.Height = 24;
            this.dataGrid_patrons.Size = new System.Drawing.Size(1033, 356);
            this.dataGrid_patrons.TabIndex = 13;
            this.dataGrid_patrons.Visible = false;
            // 
            // patronId
            // 
            this.patronId.HeaderText = "ID";
            this.patronId.Name = "patronId";
            this.patronId.ReadOnly = true;
            this.patronId.Width = 70;
            // 
            // patronLastName
            // 
            this.patronLastName.HeaderText = "Last Name";
            this.patronLastName.Name = "patronLastName";
            this.patronLastName.ReadOnly = true;
            // 
            // patronMinit
            // 
            this.patronMinit.HeaderText = "Middle Name Init";
            this.patronMinit.Name = "patronMinit";
            this.patronMinit.ReadOnly = true;
            this.patronMinit.Width = 70;
            // 
            // patronFirstName
            // 
            this.patronFirstName.HeaderText = "First Name";
            this.patronFirstName.Name = "patronFirstName";
            this.patronFirstName.ReadOnly = true;
            // 
            // CheckedOutBooks
            // 
            this.CheckedOutBooks.HeaderText = "Checked Out Books";
            this.CheckedOutBooks.Name = "CheckedOutBooks";
            this.CheckedOutBooks.ReadOnly = true;
            // 
            // patronsOverdueBooks
            // 
            this.patronsOverdueBooks.HeaderText = "Overdue Books";
            this.patronsOverdueBooks.Name = "patronsOverdueBooks";
            this.patronsOverdueBooks.ReadOnly = true;
            // 
            // patronType
            // 
            this.patronType.HeaderText = "Type";
            this.patronType.Name = "patronType";
            this.patronType.ReadOnly = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // btn_seePatronBooks
            // 
            this.btn_seePatronBooks.Location = new System.Drawing.Point(263, 457);
            this.btn_seePatronBooks.Name = "btn_seePatronBooks";
            this.btn_seePatronBooks.Size = new System.Drawing.Size(164, 39);
            this.btn_seePatronBooks.TabIndex = 14;
            this.btn_seePatronBooks.Text = "See Patron\'s Books";
            this.btn_seePatronBooks.UseVisualStyleBackColor = true;
            this.btn_seePatronBooks.Visible = false;
            this.btn_seePatronBooks.Click += new System.EventHandler(this.btn_seePatronBooks_Click);
            // 
            // btn_addPatron
            // 
            this.btn_addPatron.Location = new System.Drawing.Point(421, 457);
            this.btn_addPatron.Name = "btn_addPatron";
            this.btn_addPatron.Size = new System.Drawing.Size(172, 39);
            this.btn_addPatron.TabIndex = 14;
            this.btn_addPatron.Text = "Add Patron";
            this.btn_addPatron.UseVisualStyleBackColor = true;
            this.btn_addPatron.Visible = false;
            this.btn_addPatron.Click += new System.EventHandler(this.btn_addPatron_Click);
            // 
            // btn_goBackPatrons
            // 
            this.btn_goBackPatrons.Location = new System.Drawing.Point(590, 457);
            this.btn_goBackPatrons.Name = "btn_goBackPatrons";
            this.btn_goBackPatrons.Size = new System.Drawing.Size(173, 39);
            this.btn_goBackPatrons.TabIndex = 15;
            this.btn_goBackPatrons.Text = "Go Back";
            this.btn_goBackPatrons.UseVisualStyleBackColor = true;
            this.btn_goBackPatrons.Visible = false;
            this.btn_goBackPatrons.Click += new System.EventHandler(this.btn_goBackPatrons_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbx_patronId
            // 
            this.tbx_patronId.Location = new System.Drawing.Point(492, 222);
            this.tbx_patronId.Name = "tbx_patronId";
            this.tbx_patronId.Size = new System.Drawing.Size(121, 22);
            this.tbx_patronId.TabIndex = 17;
            this.tbx_patronId.Visible = false;
            // 
            // lbl_patronId
            // 
            this.lbl_patronId.AutoSize = true;
            this.lbl_patronId.Location = new System.Drawing.Point(464, 220);
            this.lbl_patronId.Name = "lbl_patronId";
            this.lbl_patronId.Size = new System.Drawing.Size(21, 17);
            this.lbl_patronId.TabIndex = 18;
            this.lbl_patronId.Text = "ID";
            this.lbl_patronId.Visible = false;
            // 
            // tbx_patronFirstName
            // 
            this.tbx_patronFirstName.Location = new System.Drawing.Point(492, 250);
            this.tbx_patronFirstName.Name = "tbx_patronFirstName";
            this.tbx_patronFirstName.Size = new System.Drawing.Size(121, 22);
            this.tbx_patronFirstName.TabIndex = 18;
            this.tbx_patronFirstName.Visible = false;
            // 
            // tbx_patronMinit
            // 
            this.tbx_patronMinit.Location = new System.Drawing.Point(492, 278);
            this.tbx_patronMinit.Name = "tbx_patronMinit";
            this.tbx_patronMinit.Size = new System.Drawing.Size(121, 22);
            this.tbx_patronMinit.TabIndex = 19;
            this.tbx_patronMinit.Visible = false;
            // 
            // lbl_mInit
            // 
            this.lbl_mInit.AutoSize = true;
            this.lbl_mInit.Location = new System.Drawing.Point(414, 281);
            this.lbl_mInit.Name = "lbl_mInit";
            this.lbl_mInit.Size = new System.Drawing.Size(71, 17);
            this.lbl_mInit.TabIndex = 18;
            this.lbl_mInit.Text = "Middle Init";
            this.lbl_mInit.Visible = false;
            // 
            // tbx_patronLastName
            // 
            this.tbx_patronLastName.Location = new System.Drawing.Point(492, 306);
            this.tbx_patronLastName.Name = "tbx_patronLastName";
            this.tbx_patronLastName.Size = new System.Drawing.Size(121, 22);
            this.tbx_patronLastName.TabIndex = 20;
            this.tbx_patronLastName.Visible = false;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(410, 311);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(76, 17);
            this.lbl_LastName.TabIndex = 18;
            this.lbl_LastName.Text = "Last Name";
            this.lbl_LastName.Visible = false;
            // 
            // drp_patronType
            // 
            this.drp_patronType.FormattingEnabled = true;
            this.drp_patronType.Items.AddRange(new object[] {
            "Adult",
            "Children"});
            this.drp_patronType.Location = new System.Drawing.Point(492, 365);
            this.drp_patronType.Name = "drp_patronType";
            this.drp_patronType.Size = new System.Drawing.Size(118, 24);
            this.drp_patronType.TabIndex = 22;
            this.drp_patronType.Visible = false;
            // 
            // lbl_patronFirstName
            // 
            this.lbl_patronFirstName.AutoSize = true;
            this.lbl_patronFirstName.Location = new System.Drawing.Point(409, 253);
            this.lbl_patronFirstName.Name = "lbl_patronFirstName";
            this.lbl_patronFirstName.Size = new System.Drawing.Size(76, 17);
            this.lbl_patronFirstName.TabIndex = 18;
            this.lbl_patronFirstName.Text = "First Name";
            this.lbl_patronFirstName.Visible = false;
            // 
            // lbl_errorId
            // 
            this.lbl_errorId.AutoSize = true;
            this.lbl_errorId.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorId.Location = new System.Drawing.Point(619, 225);
            this.lbl_errorId.Name = "lbl_errorId";
            this.lbl_errorId.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorId.TabIndex = 20;
            this.lbl_errorId.Text = "*";
            this.lbl_errorId.Visible = false;
            // 
            // lbl_errorName
            // 
            this.lbl_errorName.AutoSize = true;
            this.lbl_errorName.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorName.Location = new System.Drawing.Point(619, 253);
            this.lbl_errorName.Name = "lbl_errorName";
            this.lbl_errorName.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorName.TabIndex = 20;
            this.lbl_errorName.Text = "*";
            this.lbl_errorName.Visible = false;
            // 
            // lbl_errorMiddleInit
            // 
            this.lbl_errorMiddleInit.AutoSize = true;
            this.lbl_errorMiddleInit.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorMiddleInit.Location = new System.Drawing.Point(619, 281);
            this.lbl_errorMiddleInit.Name = "lbl_errorMiddleInit";
            this.lbl_errorMiddleInit.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorMiddleInit.TabIndex = 20;
            this.lbl_errorMiddleInit.Text = "*";
            this.lbl_errorMiddleInit.Visible = false;
            // 
            // lbl_errorLastName
            // 
            this.lbl_errorLastName.AutoSize = true;
            this.lbl_errorLastName.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorLastName.Location = new System.Drawing.Point(619, 311);
            this.lbl_errorLastName.Name = "lbl_errorLastName";
            this.lbl_errorLastName.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorLastName.TabIndex = 20;
            this.lbl_errorLastName.Text = "*";
            this.lbl_errorLastName.Visible = false;
            // 
            // lbl_errorPatronType
            // 
            this.lbl_errorPatronType.AutoSize = true;
            this.lbl_errorPatronType.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorPatronType.Location = new System.Drawing.Point(619, 368);
            this.lbl_errorPatronType.Name = "lbl_errorPatronType";
            this.lbl_errorPatronType.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorPatronType.TabIndex = 20;
            this.lbl_errorPatronType.Text = "*";
            this.lbl_errorPatronType.Visible = false;
            // 
            // tbx_phoneNumber
            // 
            this.tbx_phoneNumber.Location = new System.Drawing.Point(492, 334);
            this.tbx_phoneNumber.Name = "tbx_phoneNumber";
            this.tbx_phoneNumber.Size = new System.Drawing.Size(121, 22);
            this.tbx_phoneNumber.TabIndex = 21;
            this.tbx_phoneNumber.Visible = false;
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(382, 339);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lbl_phoneNumber.TabIndex = 18;
            this.lbl_phoneNumber.Text = "Phone Number";
            this.lbl_phoneNumber.Visible = false;
            // 
            // lbl_errorPhoneNumber
            // 
            this.lbl_errorPhoneNumber.AutoSize = true;
            this.lbl_errorPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorPhoneNumber.Location = new System.Drawing.Point(619, 339);
            this.lbl_errorPhoneNumber.Name = "lbl_errorPhoneNumber";
            this.lbl_errorPhoneNumber.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorPhoneNumber.TabIndex = 20;
            this.lbl_errorPhoneNumber.Text = "*";
            this.lbl_errorPhoneNumber.Visible = false;
            // 
            // btn_addPatronToDB
            // 
            this.btn_addPatronToDB.Location = new System.Drawing.Point(472, 412);
            this.btn_addPatronToDB.Name = "btn_addPatronToDB";
            this.btn_addPatronToDB.Size = new System.Drawing.Size(75, 23);
            this.btn_addPatronToDB.TabIndex = 23;
            this.btn_addPatronToDB.Text = "Add";
            this.btn_addPatronToDB.UseVisualStyleBackColor = true;
            this.btn_addPatronToDB.Visible = false;
            this.btn_addPatronToDB.Click += new System.EventHandler(this.btn_addPatronToDB_Click);
            // 
            // btn_cancelPatron
            // 
            this.btn_cancelPatron.Location = new System.Drawing.Point(556, 412);
            this.btn_cancelPatron.Name = "btn_cancelPatron";
            this.btn_cancelPatron.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelPatron.TabIndex = 24;
            this.btn_cancelPatron.Text = "Cancel";
            this.btn_cancelPatron.UseVisualStyleBackColor = true;
            this.btn_cancelPatron.Visible = false;
            this.btn_cancelPatron.Click += new System.EventHandler(this.btn_cancelPatron_Click);
            // 
            // lbl_bookId
            // 
            this.lbl_bookId.AutoSize = true;
            this.lbl_bookId.Location = new System.Drawing.Point(404, 253);
            this.lbl_bookId.Name = "lbl_bookId";
            this.lbl_bookId.Size = new System.Drawing.Size(57, 17);
            this.lbl_bookId.TabIndex = 8;
            this.lbl_bookId.Text = "Book ID";
            this.lbl_bookId.Visible = false;
            // 
            // tbx_bookID
            // 
            this.tbx_bookID.Location = new System.Drawing.Point(491, 253);
            this.tbx_bookID.Name = "tbx_bookID";
            this.tbx_bookID.Size = new System.Drawing.Size(157, 22);
            this.tbx_bookID.TabIndex = 9;
            this.tbx_bookID.Visible = false;
            // 
            // lbl_errorBookID
            // 
            this.lbl_errorBookID.AutoSize = true;
            this.lbl_errorBookID.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorBookID.Location = new System.Drawing.Point(654, 253);
            this.lbl_errorBookID.Name = "lbl_errorBookID";
            this.lbl_errorBookID.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorBookID.TabIndex = 12;
            this.lbl_errorBookID.Text = "*";
            this.lbl_errorBookID.Visible = false;
            // 
            // drp_patronsIds
            // 
            this.drp_patronsIds.FormattingEnabled = true;
            this.drp_patronsIds.Location = new System.Drawing.Point(505, 254);
            this.drp_patronsIds.Name = "drp_patronsIds";
            this.drp_patronsIds.Size = new System.Drawing.Size(121, 24);
            this.drp_patronsIds.TabIndex = 25;
            this.drp_patronsIds.Visible = false;
            // 
            // lbl_selectAuser
            // 
            this.lbl_selectAuser.AutoSize = true;
            this.lbl_selectAuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_selectAuser.Location = new System.Drawing.Point(359, 254);
            this.lbl_selectAuser.Name = "lbl_selectAuser";
            this.lbl_selectAuser.Size = new System.Drawing.Size(140, 17);
            this.lbl_selectAuser.TabIndex = 26;
            this.lbl_selectAuser.Text = "Please select a user:";
            this.lbl_selectAuser.Visible = false;
            // 
            // dat_bookDateCheckedOut
            // 
            this.dat_bookDateCheckedOut.Enabled = false;
            this.dat_bookDateCheckedOut.Location = new System.Drawing.Point(426, 289);
            this.dat_bookDateCheckedOut.Name = "dat_bookDateCheckedOut";
            this.dat_bookDateCheckedOut.Size = new System.Drawing.Size(200, 22);
            this.dat_bookDateCheckedOut.TabIndex = 27;
            this.dat_bookDateCheckedOut.Visible = false;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(362, 331);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(99, 23);
            this.btn_checkout.TabIndex = 28;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Visible = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // lbl_currentStatusDYNAMIC
            // 
            this.lbl_currentStatusDYNAMIC.AutoSize = true;
            this.lbl_currentStatusDYNAMIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentStatusDYNAMIC.Location = new System.Drawing.Point(520, 223);
            this.lbl_currentStatusDYNAMIC.Name = "lbl_currentStatusDYNAMIC";
            this.lbl_currentStatusDYNAMIC.Size = new System.Drawing.Size(74, 17);
            this.lbl_currentStatusDYNAMIC.TabIndex = 29;
            this.lbl_currentStatusDYNAMIC.Text = "Available";
            this.lbl_currentStatusDYNAMIC.Visible = false;
            // 
            // btn_checkin
            // 
            this.btn_checkin.Location = new System.Drawing.Point(468, 331);
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(99, 23);
            this.btn_checkin.TabIndex = 30;
            this.btn_checkin.Text = "Checkin";
            this.btn_checkin.UseVisualStyleBackColor = true;
            this.btn_checkin.Visible = false;
            this.btn_checkin.Click += new System.EventHandler(this.btn_checkin_Click);
            // 
            // dat_todaysDate
            // 
            this.dat_todaysDate.Enabled = false;
            this.dat_todaysDate.Location = new System.Drawing.Point(863, 67);
            this.dat_todaysDate.Name = "dat_todaysDate";
            this.dat_todaysDate.Size = new System.Drawing.Size(200, 22);
            this.dat_todaysDate.TabIndex = 31;
            // 
            // lbl_todaysdate
            // 
            this.lbl_todaysdate.AutoSize = true;
            this.lbl_todaysdate.Location = new System.Drawing.Point(918, 47);
            this.lbl_todaysdate.Name = "lbl_todaysdate";
            this.lbl_todaysdate.Size = new System.Drawing.Size(98, 17);
            this.lbl_todaysdate.TabIndex = 32;
            this.lbl_todaysdate.Text = "Today\'s date: ";
            // 
            // btn_updateDate
            // 
            this.btn_updateDate.Location = new System.Drawing.Point(907, 21);
            this.btn_updateDate.Name = "btn_updateDate";
            this.btn_updateDate.Size = new System.Drawing.Size(119, 23);
            this.btn_updateDate.TabIndex = 33;
            this.btn_updateDate.Text = "Update date";
            this.btn_updateDate.UseVisualStyleBackColor = true;
            this.btn_updateDate.Visible = false;
            this.btn_updateDate.Click += new System.EventHandler(this.btn_updateDate_Click);
            // 
            // btn_goBackSeePatronsBooks
            // 
            this.btn_goBackSeePatronsBooks.Location = new System.Drawing.Point(421, 457);
            this.btn_goBackSeePatronsBooks.Name = "btn_goBackSeePatronsBooks";
            this.btn_goBackSeePatronsBooks.Size = new System.Drawing.Size(172, 39);
            this.btn_goBackSeePatronsBooks.TabIndex = 34;
            this.btn_goBackSeePatronsBooks.Text = "Go Back";
            this.btn_goBackSeePatronsBooks.UseVisualStyleBackColor = true;
            this.btn_goBackSeePatronsBooks.Visible = false;
            this.btn_goBackSeePatronsBooks.Click += new System.EventHandler(this.btn_goBackSeePatronsBooks_Click);
            // 
            // lbl_patronRecord
            // 
            this.lbl_patronRecord.AutoSize = true;
            this.lbl_patronRecord.Location = new System.Drawing.Point(489, 72);
            this.lbl_patronRecord.Name = "lbl_patronRecord";
            this.lbl_patronRecord.Size = new System.Drawing.Size(46, 17);
            this.lbl_patronRecord.TabIndex = 35;
            this.lbl_patronRecord.Text = "label1";
            this.lbl_patronRecord.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 537);
            this.Controls.Add(this.lbl_patronRecord);
            this.Controls.Add(this.btn_goBackSeePatronsBooks);
            this.Controls.Add(this.btn_updateDate);
            this.Controls.Add(this.lbl_todaysdate);
            this.Controls.Add(this.dat_todaysDate);
            this.Controls.Add(this.btn_checkin);
            this.Controls.Add(this.lbl_currentStatusDYNAMIC);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.dat_bookDateCheckedOut);
            this.Controls.Add(this.lbl_selectAuser);
            this.Controls.Add(this.drp_patronsIds);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_goBackBooks);
            this.Controls.Add(this.btn_sortByName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_currentStatus);
            this.Controls.Add(this.btn_patrons);
            this.Controls.Add(this.btn_books);
            this.Controls.Add(this.btn_addBook);
            this.Controls.Add(this.btn_cancelPatron);
            this.Controls.Add(this.btn_addPatronToDB);
            this.Controls.Add(this.tbx_patronId);
            this.Controls.Add(this.tbx_patronFirstName);
            this.Controls.Add(this.lbl_patronFirstName);
            this.Controls.Add(this.tbx_patronMinit);
            this.Controls.Add(this.lbl_phoneNumber);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_mInit);
            this.Controls.Add(this.lbl_patronId);
            this.Controls.Add(this.drp_patronType);
            this.Controls.Add(this.tbx_phoneNumber);
            this.Controls.Add(this.tbx_patronLastName);
            this.Controls.Add(this.lbl_errorPatronType);
            this.Controls.Add(this.lbl_errorPhoneNumber);
            this.Controls.Add(this.lbl_errorLastName);
            this.Controls.Add(this.lbl_errorName);
            this.Controls.Add(this.lbl_errorId);
            this.Controls.Add(this.lbl_errorMiddleInit);
            this.Controls.Add(this.lbl_errorDropAddBook);
            this.Controls.Add(this.lbl_errorBookID);
            this.Controls.Add(this.lbl_errorAddBookName);
            this.Controls.Add(this.btn_cancelBookMenu);
            this.Controls.Add(this.btn_addBookMenu);
            this.Controls.Add(this.drp_addBookType);
            this.Controls.Add(this.tbx_bookID);
            this.Controls.Add(this.tbx_bookName);
            this.Controls.Add(this.lbl_bookId);
            this.Controls.Add(this.lbl_bookName);
            this.Controls.Add(this.btn_addPatron);
            this.Controls.Add(this.btn_goBackPatrons);
            this.Controls.Add(this.btn_seePatronBooks);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.dataGrid_patrons);
            this.Controls.Add(this.dataGrid_books);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_patrons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_changeTodaysTools;
        private System.Windows.Forms.Button btn_books;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Button btn_patrons;
        private System.Windows.Forms.DataGridView dataGrid_books;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Button btn_sortByName;
        private System.Windows.Forms.Button btn_goBackBooks;
        private System.Windows.Forms.Label lbl_currentStatus;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_bookName;
        private System.Windows.Forms.TextBox tbx_bookName;
        private System.Windows.Forms.ComboBox drp_addBookType;
        private System.Windows.Forms.Button btn_addBookMenu;
        private System.Windows.Forms.Button btn_cancelBookMenu;
        private System.Windows.Forms.Label lbl_errorAddBookName;
        private System.Windows.Forms.Label lbl_errorDropAddBook;
        private System.Windows.Forms.DataGridView dataGrid_patrons;
        private System.Windows.Forms.Button btn_seePatronBooks;
        private System.Windows.Forms.Button btn_addPatron;
        private System.Windows.Forms.Button btn_goBackPatrons;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbx_patronId;
        private System.Windows.Forms.Label lbl_patronId;
        private System.Windows.Forms.TextBox tbx_patronFirstName;
        private System.Windows.Forms.TextBox tbx_patronMinit;
        private System.Windows.Forms.Label lbl_mInit;
        private System.Windows.Forms.TextBox tbx_patronLastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.ComboBox drp_patronType;
        private System.Windows.Forms.Label lbl_patronFirstName;
        private System.Windows.Forms.Label lbl_errorId;
        private System.Windows.Forms.Label lbl_errorName;
        private System.Windows.Forms.Label lbl_errorMiddleInit;
        private System.Windows.Forms.Label lbl_errorLastName;
        private System.Windows.Forms.Label lbl_errorPatronType;
        private System.Windows.Forms.TextBox tbx_phoneNumber;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private System.Windows.Forms.Label lbl_errorPhoneNumber;
        private System.Windows.Forms.Button btn_addPatronToDB;
        private System.Windows.Forms.Button btn_cancelPatron;
        private System.Windows.Forms.Label lbl_bookId;
        private System.Windows.Forms.TextBox tbx_bookID;
        private System.Windows.Forms.Label lbl_errorBookID;
        private System.Windows.Forms.ComboBox drp_patronsIds;
        private System.Windows.Forms.Label lbl_selectAuser;
        private System.Windows.Forms.DateTimePicker dat_bookDateCheckedOut;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label lbl_currentStatusDYNAMIC;
        private System.Windows.Forms.Button btn_checkin;
        private System.Windows.Forms.DateTimePicker dat_todaysDate;
        private System.Windows.Forms.Label lbl_todaysdate;
        private System.Windows.Forms.Button btn_updateDate;
        private System.Windows.Forms.ToolStripMenuItem changeTodaysDateToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckoutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronMinit;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedOutBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronsOverdueBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronType;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.Button btn_goBackSeePatronsBooks;
        private System.Windows.Forms.Label lbl_patronRecord;
    }
}

