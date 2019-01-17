using System;
using System.Collections.Generic;
using System.Text;

namespace Class08d6Demo
{
    class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int NumberOfPages { get; set; }
        public Category Genre { get; set; }

    }

    enum Category
    {
        Fantasy,
        Mystery,
        Romance,
        SciFi
    }

}
