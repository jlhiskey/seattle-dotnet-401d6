using System;
using System.Collections.Generic;
using System.Linq;

namespace Class08d6Demo
{
    // has a return type of void and accepts no arguments
    delegate void MyDelegate();

    delegate bool NumberDelegate(int n);


    // THe compiler makes the class for us behind the scenes
    // class MyDelegate{

    // }
    class Program
    {
        //static bool GetAllEvens(int n) { return n % 2 == 0; }
        //static bool GetAllOdds(int n) { return n % 2 != 0; }
        static bool GetAllFives(int n) { return n % 5 == 0; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDelegate del = Greeting;
            //del();
            //del.Invoke();
            //Greeting();
            PassAdDelage(del);

            int[] myNumbers = { 2, 3, 4, 5, 6, 7, 8, 10, 44, 33, 91 };

            IEnumerable<int> allEvens = GetNumbers(myNumbers, n => n % 2 == 0);
            IEnumerable<int> allOdds = GetNumbers(myNumbers, n => n % 2 != 0);
            IEnumerable<int> allFives = GetNumbers(myNumbers, GetAllFives);

            //Console.WriteLine("=============== ALL EVENS =========");
            //foreach (var item in allEvens)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("=============== ALL ODDS =========");
            //foreach (var item in allOdds)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("=============== ALL Fives =========");
            //foreach (var item in allFives)
            //{
            //    Console.WriteLine(item);
            //}


           // PracticeLINQ();

            AnonyObjects();



            #region Commens


            //IEnumerable<int> numms = GetAllEvenNumbers(myNumbers);

            //IEnumerable<int> odds = GetAllOddNumbers(myNumbers);
            //foreach (var item in numms)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("=================");

            //foreach (var item in odds)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }

        static void Greeting()
        {
            Console.WriteLine("Hello Class");
        }

        static void PassAdDelage(MyDelegate delly)
        {
            delly();
        }

        static IEnumerable<int> GetNumbers(IEnumerable<int> numbers, NumberDelegate delly)
        {
            foreach (int item in numbers)
            {
                if (delly(item))
                {
                    yield return item;
                }
            }
        }

        static IEnumerable<int> GetAllOddNumbers(IEnumerable<int> numbers)
        {
            foreach (int item in numbers)
            {
                if (item % 2 != 0)
                {
                    yield return item;
                }
            }
        }

        static IEnumerable<int> GetAllFives(IEnumerable<int> numbers)
        {
            foreach (int item in numbers)
            {
                if (item % 5 == 0)
                {
                    yield return item;
                }
            }
        }


        static void PracticeLINQ()
        {
            // LINQ stands for Languate INtegrated Query
            List<int> myList = new List<int>()
            { 1, 2, 3, 4, 5, 6, 7, 89, 84, 38, 159 };

            //foreach (int item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerable<int> results = from n in myList
                                       where n % 2 == 0
                                       select n;

            foreach (int number in results)
            {
                Console.WriteLine(number);
            }

            IEnumerable<int> lessThan10 = from n in results
                                          where n < 10
                                          select n;

            Console.WriteLine("====LESS THAN 10==========");
            foreach (int item in lessThan10)
            {
                Console.WriteLine(item);
            }


            List<string> bestCats = new List<string> { "Josie", "Belle", "Not Gregor", "Frodo", "Trinity", "Neo", "Leia" };

            IEnumerable<string> filteredCats = from cats in bestCats
                                               where cats.Contains('e')
                                               select cats;

            foreach (var item in filteredCats)
            {
                Console.WriteLine(item);
            }

            //filteredCats.Where()

            Console.WriteLine("==========");
            var shortcats = filteredCats.Where(n => n.Length < 5);
            foreach (var item in shortcats)
            {
                Console.WriteLine(item);
            }


            // Funcs have return types!!!!
            Func<int, int, bool> myFunc = MethodThatBringsInTwoIntsAndReturnsOneBool;

            Action<int> myAction = ThisActionOnlyTakesInOneIntAndReturnsNothing;




        }

        static void AnonyObjects()
        {

            //foreach (var item in values)
            //{
            //    Console.WriteLine(item);
            //}

            Author author = new Author()
            {
                FirstName = "JK",
                LastName = "Rowling"
            };

            Author auth = new Author()
            {
                FirstName = "Dr",
                LastName = "Suess"
            };

            Book book = new Book()
            {
                Title = "Harry Potter",
                Author = author,
                NumberOfPages = 309,
                Genre = Category.Fantasy

            };

            Book book2 = new Book()
            {
                Title = "Horton Hears a Who",
                Author = auth,
                NumberOfPages = 25,
                Genre = Category.Mystery

            };

            List<Book> books = new List<Book>();

            books.Add(book);
            books.Add(book2);

           var myBooks = from b in books
                          select new { Book = b, Writer = b.Author, SirName = b.Author.LastName + b.Author.FirstName};

            foreach (var item in myBooks)
            {
                Console.WriteLine(item.SirName);
            }
        }


        static bool MethodThatBringsInTwoIntsAndReturnsOneBool(int one, int two)
        {
            return true;
        }

        static void ThisActionOnlyTakesInOneIntAndReturnsNothing(int a)
        {

        }

    }
}
