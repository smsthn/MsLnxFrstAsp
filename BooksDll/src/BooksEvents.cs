using System;
using System.Collections.Generic;
using System.Linq;

namespace BooksDll
{
    namespace Books
    {
        public partial class Books
        { 
            public delegate void BookHandler(Book book);

            public event BookHandler addBookEvent;
            public event BookHandler removeBookEvent;
            public event BookHandler modifyBookEvent;
        }
    }
}