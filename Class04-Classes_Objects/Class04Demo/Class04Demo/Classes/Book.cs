using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo.Classes
{
    class Book
    {
        public string Title { get; set; }
        public int NumberOfPages { get; set; }
        public string ISBN { get; set; }
        public bool CheckedOut { get; set; }

        public Author Author { get; set; }

        public Book(string title, Author author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

    }
}
