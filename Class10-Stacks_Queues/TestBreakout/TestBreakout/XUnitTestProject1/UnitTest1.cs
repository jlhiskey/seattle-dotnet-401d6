using System;
using TestBreakout.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        // Test Getters
        // Test Setters
        // Different Asserts
        // Theories

        [Fact]
        public void CanSetTitleOfBook()
        {
            // Arrange
            // (Setting the stage, creating/instantiating objects)
            Author author = new Author("Jk", "Rowling");
            string title = "Harry Potter";
            Book book = new Book(title, author);

            //Act
            // setting of the title
            string newTitle = "Horton Hears a Who";
            book.Title = newTitle;

            //Assert           
            Assert.Equal(newTitle, book.Title);

        }

        [Fact]
        public void CanInstantiateABookWithTitle()
        {
            // Arrange and Act
            Author author = new Author("Jk", "Rowling");
            string title = "Harry Potter";
            Book book = new Book(title, author);

            // Assert
            Assert.Equal(title, book.Title);


        }

        [Fact]
        public void CanInstantiateBookWithAuthor()
        {
            // Arrange and Act
            Author author = new Author("Jk", "Rowling");
            string title = "Harry Potter";
            Book book = new Book(title, author);

            // Assert
            Assert.Equal(author.FirstName, book.Author.FirstName);


        }

        [Fact]
        public void GetTitleOfBook()
        {
            // Arrange
            Author author = new Author("Dr.", "Suess");
            Book book = new Book("Horton Hears a Who", author);

            //Act
            string title = book.Title;

            //Assert
            Assert.Equal("Horton Hears a Who", title);

        }

        [Fact]
        public void Asserts()
        {
            Assert.InRange(10, 5, 100);
            //Assert.Throws<NullReferenceException>(() => );
            Author author = new Author("Amanda", "Rocks");
            Book book = new Book("Horton Hears a Who", author);

            bool mathEquation = (7 % 2 == 0);
            Assert.IsType<Book>(book);
            Assert.IsNotType<Book>(book);

            Assert.False(mathEquation);

        }


        // Conditionally True
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(880)]
        static void TestEvenNumbers(int number)
        {
            bool isEven = false;
            if(number % 2 == 0)
            {
                isEven = true;
            }

            Assert.True(isEven);
        }


       
        

    }
}
