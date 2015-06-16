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
                if (b.Id == uint.Parse(bookId))
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
            myFile.DB = ld;
            myFile.writeDB();
        }
    }//end class
}
