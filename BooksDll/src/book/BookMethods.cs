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
            /// <summary>
            /// this Method Removes a Tags Based on the index of it
            /// </summary>
            /// <param name="index"> the index to remove</param>
            /// <throws name="ArgumentException" >in case index was not in Notes List</throws>
            /// <returns> the removed Tag String</returns>
            public string RemoveTag(int index){
                if( index < 0 || index > Tags.Count()){
                    throw new ArgumentException("Value Is Not In Notes");
                }
                String tag = Tags[index];
                Tags.RemoveAt(index);
                return tag;
            }
        }
    }
}