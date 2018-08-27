using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using BooksDll.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using log4net;
using System.IO;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace BooksTest
{
    [TestClass]
    public class BooksTest{

        Books books;
        private string str = "ssss";

        [TestInitialize]
        public void setUp(){
            books = new Books();
        }

        [TestMethod]
        public void TestAddEvent(){
            books.addBookEvent += testLstner;
            Book book  = new Book("Name","Catagory","ReadingStatus",new List<string>());
            books.AddBook(book);
            Assert.AreEqual("Name",str);
        }
        private void testLstner(Book book){
            str = book.Name;
        }

    }
}