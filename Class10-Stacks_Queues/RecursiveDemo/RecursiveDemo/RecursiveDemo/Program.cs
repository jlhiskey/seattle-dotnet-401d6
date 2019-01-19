using RecursiveDemo.Classes;
using System;

namespace RecursiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Console.WriteLine(FactorialIterative(4));

            //Console.WriteLine(FactorialRecursive(4));

           // Console.WriteLine(Fib(8));
         //   Console.WriteLine(FibR(8));

            LinkedListExample();


        }

        static void LinkedListExample()
        {
            LList list = new LList();

            list.Insert(42);
            list.Insert(23);
            list.Insert(16);
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            list.Current = list.Head;
            

           // Console.WriteLine("ITERATIVE");
           // list.Print();

           // Console.WriteLine("RECURSIVE");
           // list.RecursivePrint(list.Head);

          Node recursive =  list.RecursiveFind(76, list.Head);

            //Console.WriteLine(recursive.Value);
            Console.WriteLine(list.FindRecursive(23).Value);
        }

        static long FactorialIterative(int n)
        {
            // creating our value to hold the answer
            long value = 1;
            // make sure we don't multiply by zero
            if(n == 0)
            {
                return 1;
            }
            // start our forloop at n and decrease until we hit 1. 

            for (int i = n; i > 0; i--)
            {
                value *= i;

            }

            // return our factorial
            return value;
           
        }

        static long FactorialRecursive(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            long answer =  n * FactorialRecursive(n - 1);
            return answer;

        }

        static long Fib(int n)
        {
            if(n < 2)
            {
                return n;
            }
            long[] fibArray = new long[n + 1];
            fibArray[0] = 0;
            fibArray[1] = 1;

            for (int i = 2; i <= n ; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
            }
            return fibArray[n];
        }

        static long FibR(int n)
        {
            if(n == 0 || n ==1 )
            {
                return n;
            }

            return FibR(n - 2) + FibR(n - 1);
        }

    }
}
