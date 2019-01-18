using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPizzaDemo.Classes
{
    abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing Pizza {Name}");

            foreach (string ing in Ingredients)
            {
                Console.WriteLine(ing);
            }

        }

        public void Bake()
        {
            Console.WriteLine("BAKING THE PIZZA");
        }

        public void Cut()
        {
            Console.WriteLine("Cut the pizza!!");
        }

        public void Box()
        {
            Console.WriteLine("Box the Pizza!!");
        }

    }
}
