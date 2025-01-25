using SimpleFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class PizzaStore
    {
        private readonly SimplePizzaFactory simplePizzaFactory;

        public PizzaStore(SimplePizzaFactory pizzaFactory) {
            this.simplePizzaFactory = pizzaFactory;
        }

        public IPizza OrderPizza(string type)
        {
            var pizza = simplePizzaFactory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
