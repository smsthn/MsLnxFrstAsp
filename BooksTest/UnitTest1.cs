using Microsoft.VisualStudio.TestTools.UnitTesting;
using BooksDll.Books;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BooksTest
{
    [TestClass]
    public class UnitTest1
    {
        private Book book;

        [TestInitialize]
        public void setUp()
        {
            book = new Book("Name", "Catagory", "ReadingStatus", new List<string>() { "tag1", "tag2", "tag3" });
        }

        [TestMethod]
        public void TestMethod1()
        {

            Assert.IsNotNull(book);
            Assert.AreEqual("Name", book.Name);
            Assert.AreEqual("Catagory", book.Catagory);
            Assert.AreEqual("ReadingStatus", book.ReadingStatus);
            Assert.IsFalse(book.Tags.Count() == 0, "Not False");
        }

        [TestMethod]
        public void AddAndRemove(){
            Assert.AreEqual("tag1",book.RemoveTag("tag1"));
            Assert.AreEqual(2,book.Tags.Count());
        }
    }
}
