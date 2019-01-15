using Class04Demo.Classes;
using System;
using System.Text;

namespace Class04Demo
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Hello World!");
            //CommentExample()
            PersonExample();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        static string CommentExample(string name, int age)
        {
            string[] arr = { "cat", "dog" };



            // returns Amanda
            return "Amanda";
        }

        static void PersonExample()

        {
            // instantiation of an object of type Person
            Person amanda = new Person("Josie");
            Person mike = new Person(40);

            amanda.Name = "Amanda"; // set
            string name = amanda.Name; // get

            amanda.Age = 16;

            Console.WriteLine($"Amanda looks {amanda.Age} years old");
            amanda.Speak("Hello World");


            // instantiating a new person

            Person gwen = new Person();
            gwen.Speak("The rain.....");
            Console.WriteLine($"Gwen's name is: {gwen.Name}");

            gwen.Name = "Gwen";


            Console.WriteLine($"Gwen's name is: {gwen.Name}");

            Library library = new Library("Amanda's Library of Fun", 10);

            //Book harryPotter = library.CheckOutBook("Harry Potter and the Sorcerer's Stone");


            Author author = new Author("JK", "Rowling");
            Author josie = author;
            Console.WriteLine("============");
            Console.WriteLine($"{author.LastName}");
            Console.WriteLine($"{josie.LastName}");

            author.LastName = "Cats";

            Console.WriteLine($"{author.LastName}");
            Console.WriteLine($"{josie.LastName}");

            Console.WriteLine("======");


            Book book = new Book("Harry Potter and the Sorcerer's Stone", author, 309);

            Console.WriteLine(book.Author.FirstName);

            Author myAuthor = new Author()
            {
                FirstName = "Amanda",
            };

            string declaration = "We the people...";
            declaration += "Of the United States....";
            declaration += "blah blah blah";

            StringBuilder sb = new StringBuilder();

            sb.Append("We the people");
            sb.AppendLine("Of the United States");
            sb.Append("Blah Blah Blah");

            string answer = sb.ToString();


        }

    }
}
