using SimpleFactoryFranchised.Pizzas;
using SimpleFactoryFranchised;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryFranchised.Factories
{
    internal class NYFactory   {
        public IPizza CreatePizza(string type)
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