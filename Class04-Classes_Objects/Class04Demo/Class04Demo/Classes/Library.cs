namespace Class04Demo.Classes
{
    class Library
    {
        public string Name { get; set; }

        public Book[] Books { get; set; }

        public Library(string name, int maxBooks)
        {
            Name = name;
            Books = new Book[maxBooks];
        }

        public Book CheckOutBook(string bookName)
        {
            Book myBook;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Title == bookName)
                {
                    myBook = Books[i];
                    Books[i].CheckedOut = true;
                    return Books[i];
                }
            }

            return null;
        }
    }
}
