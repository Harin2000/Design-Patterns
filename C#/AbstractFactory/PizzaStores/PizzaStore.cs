using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStores
{
    internal abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            // This is the issue here, different pizza stores can stop following the standard practice
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
