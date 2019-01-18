using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPizzaDemo.Classes
{
   abstract class PizzaStore
    {
       // private SimplePizzaFactory Factory;

        //public PizzaStore(SimplePizzaFactory factory)
        //{
        //    Factory = factory;
        //}

        public string Name { get; set; }

        // Factory Method. 
        protected abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            //factory = new SimplePizzaFactory();
            //Pizza pizza = Factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

      
    }
}
