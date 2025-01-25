using SimpleFactoryFranchised.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryFranchised.Factories
{
    internal class ChicagoFactory    {
        public IPizza CreatePizza(string type)
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
