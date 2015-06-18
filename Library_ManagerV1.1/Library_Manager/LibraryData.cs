using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager
{
    [Serializable]
    public class LibraryData
    {
        public List<Book> Books;
        public List<Patron> Patrons;

        public LibraryData()
        {
            this.Books = new List<Book>();
            this.Patrons = new List<Patron>();
        }

        public LibraryData(List<Book> Books, List<Patron> Patrons)
        {
            this.Books = Books;
            this.Patrons = Patrons;
        }

        public DateTime CurrentDate { get; set; }
    }
}
