using SimpleFactory.Pizzas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class SimplePizzaFactory
    {
        // Static Factory is also an option.
        // Disadvantage of static would be to not have any subclass, so we'll be unable to change the behavior of this method
        public IPizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new CheesePizza();
                case "greek":
                    return new GreekPizza();
                case "pepperoni":
                    return new PepperoniPizza();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
