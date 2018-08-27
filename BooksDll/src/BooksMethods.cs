using System;
using System.Collections.Generic;
using System.Linq;

namespace BooksDll
{
    namespace Books
    {
        public partial class Books
        {
            public List<string> GetBooksNames()
            {
                return (from book in AllBooks select book.Name).ToList();
            }
            public List<string> GetFilteredBooksNames(List<string> tags, string catagory = "Any", string readingStatus = "Any")
            {
                bool checks(Book book)
                {
                    bool ctg = book.Catagory == catagory || catagory == "Any";
                    bool rdstts = book.ReadingStatus == readingStatus || readingStatus == "Any";
                    bool tgs = true;
                    foreach (var tag in tags)
                    {
                        tgs &= book.Tags.Contains(tag);
                    }
                    return ctg && rdstts && tgs;
                }
                return (from book in AllBooks where checks(book) select book.Name).ToList();
            }
            public Book GetBook(string name)
            {
                try
                {
                   return (from book in AllBooks where book.Name == name select book).First();
                }
                catch
                {
                    return null;
                }

            }
            public Book AddBook(Book book)
            {
                if (GetBook(book.Name) != null)
                {
                    return null;
                }
                AllBooks.Add(book);
                if (addBookEvent != null)
                {
                    addBookEvent(book);
                }
                return book;
            }
            public Book AddBook(string name, string catagory, string readingStatus, List<string> tags)
            {
                Book book = new Book(name, catagory, readingStatus, tags);
                AllBooks.Add(book);
                if (addBookEvent != null)
                {
                    addBookEvent(book);
                }
                return book;
            }

            public Book ModifyBook(string name, string catagory, string readingStatus, List<string> tags, int pageNumber)
            {
                Book book = GetBook(name);
                book.Name = name;
                book.Catagory = catagory;
                book.ReadingStatus = readingStatus;
                book.Pages = pageNumber;
                book.Tags.Clear();
                book.Tags.AddRange(tags);
                if (modifyBookEvent != null)
                {
                    modifyBookEvent(book);
                }

                return book;
            }

        }
    }
}