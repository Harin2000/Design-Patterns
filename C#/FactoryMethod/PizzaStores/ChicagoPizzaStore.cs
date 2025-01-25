using FactoryMethod.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaStores
{
    internal class ChicagoPizzaStore:PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoCheesePizza();
                case "greek":
                    return new ChicagoGreekPizza();
                case "pepperoni":
                    return new ChicagoPepperoniPizza();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
