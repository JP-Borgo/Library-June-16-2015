using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Library_Manager
{
    /// <summary>
    /// IFileAccess, interface that provides all methods necessary for interaction between program and file
    /// </summary>
    public interface IFileAccess
    {
        void writeDB();
        void readDB();
        void openDB();
        void closeDB();
        LibraryData DB { get; set; }
    }//end interface IFileAccess

    [Serializable]
    public sealed class FileIO: Object, IFileAccess
    {
        private string filePath;
        private FileStream fs;
        private BinaryFormatter bf;
        private LibraryData libraryData;

        /// <summary>
        /// Purpose: Initializes data.
        /// </summary>
        public FileIO()
        {
            libraryData = new LibraryData();
            bf = new BinaryFormatter();
            filePath = "";
        }

        /// <summary>
        /// Purpose: To set the name of the file in/from which data will be read/opened
        /// </summary>
        /// <param name="_fileName"></param>
        public void setFilePath(string _filePath)
        {
            filePath = _filePath;
        }

        /// <summary>
        /// Purpose: Serializes data contained within the sorted dictionary and writes it to a file 
        ///     in binary code.
        /// </summary>
        public void writeDB()
        {
            try
            {
                bf.Serialize(fs, libraryData);
                Console.WriteLine("Write succesfully");
            }
            catch (IOException ioexp)
            {
                Console.WriteLine("IOException - {0}", ioexp.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception - {0}", exp.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }

        /// <summary>
        /// Purpose: deserializes file and takes all ojects contained within it and put them
        ///     in a sorted dictionary.
        /// </summary>
        public void readDB()
        {
            try
            {
                libraryData = new LibraryData();
                fs.Position = 0;
                libraryData = (LibraryData)bf.Deserialize(fs);
                Console.WriteLine("read succesfully");
            }
            catch (IOException ioexp)
            {
                Console.WriteLine("IOException - {0}", ioexp.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception - {0}", exp.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
                Console.WriteLine("BinaryFormatReader finally");
            }

        }

        /// <summary>
        /// Puspose: Makes a Stream which will connect the program and the file that will be
        ///     used for serialization and/or deserialization. If the file does not exist then
        ///     we create one new.
        /// </summary>
        public void openDB()
        {
            try
            {
                //if (filePath.Contains(".bin"))
                //{
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                Console.WriteLine("open");
                //}
                //else
                // Console.WriteLine("Error, file does not contains extension file .bin");
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception - {0}", exp.Message);
            }
        }

        /// <summary>
        /// Purpose: flushes and closes the file stream that was created by openDB()
        /// </summary>
        public void closeDB()
        {
            fs.Close();
        }

        /// <summary>
        /// Purpose: gets and sets the sorted dictionary that will be serialized or deserialized by FileIO class, 
        ///     which is located in BusineesRules class
        /// </summary>
        public LibraryData DB
        {
            get
            {
                return libraryData;
            }
            set
            {
                libraryData = value;
            }
        }
    }//end class
}//end namespace
