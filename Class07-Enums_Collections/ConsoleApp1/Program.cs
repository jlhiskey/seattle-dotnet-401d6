using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContainer<string> myContainer = new MyContainer<string>();
            myContainer.Add("Gregor 1");
            myContainer.Add("Gregor 2");
            myContainer.Add("Gregor 3");
            myContainer.Add("Gregor");
            myContainer.Add("Gregor");
            myContainer.Add("Gregor"); // Vinicio - RESIZE
            myContainer.Add("Gregor");
            myContainer.Add("Gregor");
            myContainer.Add("Gregor");
            myContainer.Add("Gregor");
            myContainer.Add("Gregor");

            // Vinicio - foreach (and foreach only) doesn't require you to implement
            // IEnumerable<T>, but please do it!
            foreach(string item in myContainer)
            {
                Console.WriteLine(item);
            }

            MyContainer<string> myFancyContainer = new MyContainer<string>
            {
                "Wow",
                "this is super fancy",
                "to me at least..."
            };

            foreach(string item in myFancyContainer)
            {
                Console.WriteLine(item);
            }
        }
    }
}
