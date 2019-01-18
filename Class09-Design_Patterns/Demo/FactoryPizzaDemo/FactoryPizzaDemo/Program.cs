using FactoryPizzaDemo.Classes;
using System;

namespace FactoryPizzaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PizzaExample();
        }

        static void PizzaExample()
        {
           
           
            PizzaStore pizzaPlanet = new PizzaPlanet();
            pizzaPlanet.Name = "PizzaPlanet";

          Pizza pizza =  pizzaPlanet.OrderPizza("Galactic Pepperoni");


        }
    }
}
