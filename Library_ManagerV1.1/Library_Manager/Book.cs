using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager
{
    [Serializable]
    public class Book
    {
        private string bookName;
        private uint bookId;
        private Status bookStatus;
        private BookType bookType;

        public Book(uint bookId,string bookName, Status bookStatus, BookType bookType)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.bookStatus = bookStatus;
            this.bookType = bookType;
        }

        public string Name
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public uint ID
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public Status BookStatus
        {
            get { return bookStatus; }
            set { bookStatus = value; }
        }

        public BookType Type
        {
            get { return bookType; }
            set { bookType = value; }
        }

        public DateTime CheckoutDate
        {
            get;
            set;
        }

    }//end class
}
