using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPizzaDemo.Classes
{
    class SimplePizzaFactory
    {
        public static Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;

            switch (pizzaType)
            {
                case "Cheese":
                    pizza = new Cheese();
                    pizza.Name = "Cheese";
                    break;
                case "Pepperoni":
                    pizza = new Pepperoni();
                    pizza.Name = "Pepperoni";
                    break;


                default:
                    break;
            }

            return pizza;
        }
    }
}
