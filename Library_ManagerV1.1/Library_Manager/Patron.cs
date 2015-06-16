using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager
{
    [Serializable]
    public class Patron
    {
        private uint id;
        private string lastName;
        private string midInit;
        private string firstName;
        private string phoneNumber;
        private string patronType;
        public List<Book> Books;
        public List<Book> OverdueBooks;

        public Patron(uint id,string lastName, string midInit, string firstName, string phoneNumber, string patronType) 
        {
            this.id = id;
            this.lastName = lastName;
            this.midInit = midInit;
            this.firstName = firstName;
            this.phoneNumber = phoneNumber;
            this.patronType = patronType;
            this.Books = new List<Book>();
            this.OverdueBooks = new List<Book>();
        }

        public uint ID
        {
            get { return id; }
            set { id = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string MidInit
        {
            get { return midInit; }
            set { midInit = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string PatronType
        {
            get { return patronType; }
            set { patronType = value; }
        }

        public void updateOverdue()
        {
            foreach (Book book in Books)
            {
                if (book.BookStatus == Status.Overdue)
                {
                    OverdueBooks.Add(book);
                }
            }
        }
    }//end class
}//end namespace
