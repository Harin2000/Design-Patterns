using FactoryMethod;
using FactoryMethod.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaStores
{
    internal class NYPizzaStore:PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYCheesePizza();
                case "greek":
                    return new NYGreekPizza();
                case "pepperoni":
                    return new NYPepperoniPizza();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}