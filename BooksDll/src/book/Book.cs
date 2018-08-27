using System;
using System.Collections.Generic;
using System.Linq;

namespace BooksDll{
    namespace Books{
        public partial class Book{
            public string Id{get;}
            public string Name{get; set;}
            public string Catagory{get; set;}
            public string ReadingStatus{get; set;}
            public List<string> Tags{get;private set;}
            public List<string> Notes{get; private set;}
            public int Pages{get; set;}
            public Book(string name, string catagory, string readingStatus, List<string> tags){
                Id = Guid.NewGuid().ToString();
                Name = name;
                Catagory = catagory;
                ReadingStatus = readingStatus;
                Tags = tags??new List<string>();
                Notes = new List<string>();
            }
            public Book(string name, string catagory, string readingStatus, List<string> tags,List<string> notes){
                 Id = Guid.NewGuid().ToString();
                Name = name;
                Catagory = catagory;
                ReadingStatus = readingStatus;
                Tags = tags??new List<string>();
                Notes = notes;
            }
        }
    }
}