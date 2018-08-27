using System;
using System.Collections.Generic;
using System.Linq;

namespace BooksDll
{
    namespace Books
    {
        public partial class Book
        {
            public string AddTag(String tag){
                if(Tags.Contains(tag) ||tag == null|| tag.Trim() == ""){
                    return null;
                }
                Tags.Add(tag);
                return tag;
            }
            public string AddNote(String note){
                if(note != null&& note.Trim() != ""){
                    Notes.Add(note);
                    return note;
                }
                return null;
            }
            public string RemoveTag (String tag){
                if(Tags.Contains(tag)){
                    Tags.Remove(tag);
                    return tag;
                }
                return null;
            }
        }
    }
}