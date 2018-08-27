using System;
using System.Collections.Generic;
using System.Linq;

namespace BooksDll
{
    namespace Books
    {
        public partial class Books
        {
            public List<Book> AllBooks { get; private set; }
            public List<string> AllTags { get; private set; }
            public List<string> AllCatagories { get; private set; }
            public List<string> AllReadingStatus { get; private set; }

            public Books()
            {
                AllBooks = new List<Book>();
                AllTags = new List<string>();
                AllCatagories = new List<string>();
                AllReadingStatus = new List<string>();
            }
            public Books(List<Book> books, List<string> tags, List<string> catagorie, List<string> readingStatus){
                AllBooks = books;
                AllReadingStatus = readingStatus;
                AllCatagories = catagorie;
                AllTags  = tags;
            }
        }
    }
}