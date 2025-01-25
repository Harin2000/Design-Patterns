using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaStores
{
    internal abstract class PizzaStore
    {
        public IPizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            // This is the issue here, different pizza stores can stop following the standard practice
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public abstract IPizza CreatePizza(string type);
    }
}
