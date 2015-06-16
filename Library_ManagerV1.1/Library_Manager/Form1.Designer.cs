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
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_books = new System.Windows.Forms.Button();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.btn_patrons = new System.Windows.Forms.Button();
            this.dataGrid_books = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_manage = new System.Windows.Forms.Button();
            this.btn_sortByName = new System.Windows.Forms.Button();
            this.btn_goBackBooks = new System.Windows.Forms.Button();
            this.drp_currentStatus = new System.Windows.Forms.ComboBox();
            this.lbl_currentStatus = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
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
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
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
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // btn_books
            // 
            this.btn_books.Location = new System.Drawing.Point(274, 76);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(270, 69);
            this.btn_books.TabIndex = 1;
            this.btn_books.Text = "Books";
            this.btn_books.UseVisualStyleBackColor = true;
            this.btn_books.Click += new System.EventHandler(this.btn_books_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(274, 171);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(270, 69);
            this.btn_addBook.TabIndex = 1;
            this.btn_addBook.Text = "Add Book";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // btn_patrons
            // 
            this.btn_patrons.Location = new System.Drawing.Point(274, 264);
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
            this.Status});
            this.dataGrid_books.Location = new System.Drawing.Point(145, 36);
            this.dataGrid_books.Name = "dataGrid_books";
            this.dataGrid_books.RowTemplate.Height = 24;
            this.dataGrid_books.Size = new System.Drawing.Size(522, 351);
            this.dataGrid_books.TabIndex = 2;
            this.dataGrid_books.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Name";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // Book_Type
            // 
            this.Book_Type.HeaderText = "Book Type";
            this.Book_Type.Name = "Book_Type";
            this.Book_Type.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(147, 393);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(163, 39);
            this.btn_manage.TabIndex = 3;
            this.btn_manage.Text = "Manage";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Visible = false;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // btn_sortByName
            // 
            this.btn_sortByName.Location = new System.Drawing.Point(316, 393);
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
            this.btn_goBackBooks.Location = new System.Drawing.Point(494, 393);
            this.btn_goBackBooks.Name = "btn_goBackBooks";
            this.btn_goBackBooks.Size = new System.Drawing.Size(173, 39);
            this.btn_goBackBooks.TabIndex = 3;
            this.btn_goBackBooks.Text = "Go Back";
            this.btn_goBackBooks.UseVisualStyleBackColor = true;
            this.btn_goBackBooks.Visible = false;
            this.btn_goBackBooks.Click += new System.EventHandler(this.btn_goBackBooks_Click);
            // 
            // drp_currentStatus
            // 
            this.drp_currentStatus.FormattingEnabled = true;
            this.drp_currentStatus.Items.AddRange(new object[] {
            "Available",
            "Checked Out",
            "Overdue"});
            this.drp_currentStatus.Location = new System.Drawing.Point(380, 85);
            this.drp_currentStatus.Name = "drp_currentStatus";
            this.drp_currentStatus.Size = new System.Drawing.Size(121, 24);
            this.drp_currentStatus.TabIndex = 4;
            this.drp_currentStatus.Visible = false;
            // 
            // lbl_currentStatus
            // 
            this.lbl_currentStatus.AutoSize = true;
            this.lbl_currentStatus.Location = new System.Drawing.Point(279, 88);
            this.lbl_currentStatus.Name = "lbl_currentStatus";
            this.lbl_currentStatus.Size = new System.Drawing.Size(95, 17);
            this.lbl_currentStatus.TabIndex = 5;
            this.lbl_currentStatus.Text = "current status";
            this.lbl_currentStatus.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(400, 346);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(319, 346);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 7;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Visible = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbl_bookName
            // 
            this.lbl_bookName.AutoSize = true;
            this.lbl_bookName.Location = new System.Drawing.Point(279, 182);
            this.lbl_bookName.Name = "lbl_bookName";
            this.lbl_bookName.Size = new System.Drawing.Size(81, 17);
            this.lbl_bookName.TabIndex = 8;
            this.lbl_bookName.Text = "Book Name";
            this.lbl_bookName.Visible = false;
            // 
            // tbx_bookName
            // 
            this.tbx_bookName.Location = new System.Drawing.Point(366, 182);
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
            this.drp_addBookType.Location = new System.Drawing.Point(366, 210);
            this.drp_addBookType.Name = "drp_addBookType";
            this.drp_addBookType.Size = new System.Drawing.Size(157, 24);
            this.drp_addBookType.TabIndex = 11;
            this.drp_addBookType.Visible = false;
            // 
            // btn_addBookMenu
            // 
            this.btn_addBookMenu.Location = new System.Drawing.Point(366, 240);
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
            this.btn_cancelBookMenu.Location = new System.Drawing.Point(448, 240);
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
            this.lbl_errorAddBookName.Location = new System.Drawing.Point(529, 182);
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
            this.lbl_errorDropAddBook.Location = new System.Drawing.Point(529, 208);
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
            this.dataGrid_patrons.Location = new System.Drawing.Point(29, 36);
            this.dataGrid_patrons.Name = "dataGrid_patrons";
            this.dataGrid_patrons.RowTemplate.Height = 24;
            this.dataGrid_patrons.Size = new System.Drawing.Size(841, 356);
            this.dataGrid_patrons.TabIndex = 13;
            this.dataGrid_patrons.Visible = false;
            // 
            // patronId
            // 
            this.patronId.HeaderText = "ID";
            this.patronId.Name = "patronId";
            this.patronId.ReadOnly = true;
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
            this.btn_seePatronBooks.Location = new System.Drawing.Point(149, 393);
            this.btn_seePatronBooks.Name = "btn_seePatronBooks";
            this.btn_seePatronBooks.Size = new System.Drawing.Size(172, 39);
            this.btn_seePatronBooks.TabIndex = 14;
            this.btn_seePatronBooks.Text = "See Patron\'s Books";
            this.btn_seePatronBooks.UseVisualStyleBackColor = true;
            this.btn_seePatronBooks.Visible = false;
            // 
            // btn_addPatron
            // 
            this.btn_addPatron.Location = new System.Drawing.Point(316, 393);
            this.btn_addPatron.Name = "btn_addPatron";
            this.btn_addPatron.Size = new System.Drawing.Size(185, 39);
            this.btn_addPatron.TabIndex = 14;
            this.btn_addPatron.Text = "Add Patron";
            this.btn_addPatron.UseVisualStyleBackColor = true;
            this.btn_addPatron.Visible = false;
            this.btn_addPatron.Click += new System.EventHandler(this.btn_addPatron_Click);
            // 
            // btn_goBackPatrons
            // 
            this.btn_goBackPatrons.Location = new System.Drawing.Point(498, 393);
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
            this.tbx_patronId.Location = new System.Drawing.Point(367, 125);
            this.tbx_patronId.Name = "tbx_patronId";
            this.tbx_patronId.Size = new System.Drawing.Size(121, 22);
            this.tbx_patronId.TabIndex = 17;
            this.tbx_patronId.Visible = false;
            // 
            // lbl_patronId
            // 
            this.lbl_patronId.AutoSize = true;
            this.lbl_patronId.Location = new System.Drawing.Point(339, 123);
            this.lbl_patronId.Name = "lbl_patronId";
            this.lbl_patronId.Size = new System.Drawing.Size(21, 17);
            this.lbl_patronId.TabIndex = 18;
            this.lbl_patronId.Text = "ID";
            this.lbl_patronId.Visible = false;
            // 
            // tbx_patronFirstName
            // 
            this.tbx_patronFirstName.Location = new System.Drawing.Point(367, 153);
            this.tbx_patronFirstName.Name = "tbx_patronFirstName";
            this.tbx_patronFirstName.Size = new System.Drawing.Size(121, 22);
            this.tbx_patronFirstName.TabIndex = 18;
            this.tbx_patronFirstName.Visible = false;
            // 
            // tbx_patronMinit
            // 
            this.tbx_patronMinit.Location = new System.Drawing.Point(367, 181);
            this.tbx_patronMinit.Name = "tbx_patronMinit";
            this.tbx_patronMinit.Size = new System.Drawing.Size(121, 22);
            this.tbx_patronMinit.TabIndex = 19;
            this.tbx_patronMinit.Visible = false;
            // 
            // lbl_mInit
            // 
            this.lbl_mInit.AutoSize = true;
            this.lbl_mInit.Location = new System.Drawing.Point(289, 184);
            this.lbl_mInit.Name = "lbl_mInit";
            this.lbl_mInit.Size = new System.Drawing.Size(71, 17);
            this.lbl_mInit.TabIndex = 18;
            this.lbl_mInit.Text = "Middle Init";
            this.lbl_mInit.Visible = false;
            // 
            // tbx_patronLastName
            // 
            this.tbx_patronLastName.Location = new System.Drawing.Point(367, 209);
            this.tbx_patronLastName.Name = "tbx_patronLastName";
            this.tbx_patronLastName.Size = new System.Drawing.Size(121, 22);
            this.tbx_patronLastName.TabIndex = 20;
            this.tbx_patronLastName.Visible = false;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(285, 214);
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
            this.drp_patronType.Location = new System.Drawing.Point(367, 268);
            this.drp_patronType.Name = "drp_patronType";
            this.drp_patronType.Size = new System.Drawing.Size(118, 24);
            this.drp_patronType.TabIndex = 22;
            this.drp_patronType.Visible = false;
            // 
            // lbl_patronFirstName
            // 
            this.lbl_patronFirstName.AutoSize = true;
            this.lbl_patronFirstName.Location = new System.Drawing.Point(284, 156);
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
            this.lbl_errorId.Location = new System.Drawing.Point(494, 128);
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
            this.lbl_errorName.Location = new System.Drawing.Point(494, 156);
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
            this.lbl_errorMiddleInit.Location = new System.Drawing.Point(494, 184);
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
            this.lbl_errorLastName.Location = new System.Drawing.Point(494, 214);
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
            this.lbl_errorPatronType.Location = new System.Drawing.Point(494, 271);
            this.lbl_errorPatronType.Name = "lbl_errorPatronType";
            this.lbl_errorPatronType.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorPatronType.TabIndex = 20;
            this.lbl_errorPatronType.Text = "*";
            this.lbl_errorPatronType.Visible = false;
            // 
            // tbx_phoneNumber
            // 
            this.tbx_phoneNumber.Location = new System.Drawing.Point(367, 237);
            this.tbx_phoneNumber.Name = "tbx_phoneNumber";
            this.tbx_phoneNumber.Size = new System.Drawing.Size(121, 22);
            this.tbx_phoneNumber.TabIndex = 21;
            this.tbx_phoneNumber.Visible = false;
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(257, 242);
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
            this.lbl_errorPhoneNumber.Location = new System.Drawing.Point(494, 242);
            this.lbl_errorPhoneNumber.Name = "lbl_errorPhoneNumber";
            this.lbl_errorPhoneNumber.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorPhoneNumber.TabIndex = 20;
            this.lbl_errorPhoneNumber.Text = "*";
            this.lbl_errorPhoneNumber.Visible = false;
            // 
            // btn_addPatronToDB
            // 
            this.btn_addPatronToDB.Location = new System.Drawing.Point(347, 315);
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
            this.btn_cancelPatron.Location = new System.Drawing.Point(431, 315);
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
            this.lbl_bookId.Location = new System.Drawing.Point(279, 156);
            this.lbl_bookId.Name = "lbl_bookId";
            this.lbl_bookId.Size = new System.Drawing.Size(57, 17);
            this.lbl_bookId.TabIndex = 8;
            this.lbl_bookId.Text = "Book ID";
            this.lbl_bookId.Visible = false;
            // 
            // tbx_bookID
            // 
            this.tbx_bookID.Location = new System.Drawing.Point(366, 156);
            this.tbx_bookID.Name = "tbx_bookID";
            this.tbx_bookID.Size = new System.Drawing.Size(157, 22);
            this.tbx_bookID.TabIndex = 9;
            this.tbx_bookID.Visible = false;
            // 
            // lbl_errorBookID
            // 
            this.lbl_errorBookID.AutoSize = true;
            this.lbl_errorBookID.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorBookID.Location = new System.Drawing.Point(529, 156);
            this.lbl_errorBookID.Name = "lbl_errorBookID";
            this.lbl_errorBookID.Size = new System.Drawing.Size(13, 17);
            this.lbl_errorBookID.TabIndex = 12;
            this.lbl_errorBookID.Text = "*";
            this.lbl_errorBookID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 444);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_goBackBooks);
            this.Controls.Add(this.btn_sortByName);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.drp_currentStatus);
            this.Controls.Add(this.lbl_currentStatus);
            this.Controls.Add(this.dataGrid_patrons);
            this.Controls.Add(this.dataGrid_books);
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
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.Button btn_books;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Button btn_patrons;
        private System.Windows.Forms.DataGridView dataGrid_books;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Button btn_sortByName;
        private System.Windows.Forms.Button btn_goBackBooks;
        private System.Windows.Forms.ComboBox drp_currentStatus;
        private System.Windows.Forms.Label lbl_currentStatus;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_bookName;
        private System.Windows.Forms.TextBox tbx_bookName;
        private System.Windows.Forms.ComboBox drp_addBookType;
        private System.Windows.Forms.Button btn_addBookMenu;
        private System.Windows.Forms.Button btn_cancelBookMenu;
        private System.Windows.Forms.Label lbl_errorAddBookName;
        private System.Windows.Forms.Label lbl_errorDropAddBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dataGrid_patrons;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronMinit;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedOutBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronsOverdueBooks;
        private System.Windows.Forms.Button btn_seePatronBooks;
        private System.Windows.Forms.Button btn_addPatron;
        private System.Windows.Forms.Button btn_goBackPatrons;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronType;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
    }
}

