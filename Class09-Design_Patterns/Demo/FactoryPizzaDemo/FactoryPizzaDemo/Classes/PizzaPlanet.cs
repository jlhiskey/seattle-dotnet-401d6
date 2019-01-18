using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPizzaDemo.Classes
{
    class PizzaPlanet : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            return PizzaPlanetFactory.CreatePizza(type);
           // Pizza Planet has to be able to create a pizza

        }
    }
}
