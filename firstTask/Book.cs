using System;
using System.Collections.Generic;
using System.Text;

namespace firstTask
{
    internal class Book
    {
        public string title;
        public int pages;

        public override string ToString()
        {
            return $"book title : {title} , numbers of pages : {pages}";
        }
    }
}
