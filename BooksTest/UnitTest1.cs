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
    public class UnitTest1
    {
        private Book book;
        private ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

       [AssemblyInitialize]
        public static void Configure(TestContext tc)
        {
            
           
        }
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
        public void AddAndRemove()
        {
            Assert.AreEqual("tag1", book.RemoveTag("tag1"));
            Assert.AreEqual(2, book.Tags.Count());
            Assert.AreEqual("tag4", book.AddTag("tag4"));
            string json = JsonConvert.SerializeObject(book);
            File.WriteAllText("JsonLog.log",json);  
        }
    }
}
