using System;
using System.Linq;

namespace Store
{
    public class Book : Product
    {
        //fields
        private string bookAuthor;
        //private string bookTitle;
        private Genre bookGenre;
        private Nationality bookLanguage;

        //constructor
        public Book(decimal price, int quantity, string name, string author, Genre genre, Nationality language, decimal discount, bool isForRent = false)
            : base(price, quantity, name,discount,isForRent)
        {
            this.bookAuthor = author;
            this.bookGenre = genre;
            this.bookLanguage = language;
        }

        //properties
        public string BookAuthor
        {
            get
            {
                return this.bookAuthor;
            }

            set
            {
                this.bookAuthor = value;
            }
        }

        public Genre BookGenre
        {
            get
            {
                return this.bookGenre;
            }

            set
            {
                this.bookGenre = value;
            }
        }

        public Nationality BookLanguage
        {
            get
            {
                return this.bookLanguage;
            }

            set
            {
                this.bookLanguage = value;
            }
        }
       // //Implementing ISearchable
       //public List<string> Search { get; set; }
       
       // public bool SearchByName(string name)
       // {
       //     //this.bookAuthor = name;
            
       //         //Search.Add(name);
       //         bool findInList= Search.Contains(name);
       //         return findInList;            
  //      }
  }
}