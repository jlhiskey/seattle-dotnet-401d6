namespace TestBreakout.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }


        public Book(string title, Author author)
        {
            Title = title;
            Author = author;
        }
    }
}
