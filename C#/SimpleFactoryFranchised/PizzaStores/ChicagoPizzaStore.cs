using SimpleFactoryFranchised.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryFranchised.PizzaStores
{
    internal class ChicagoPizzaStore
    {
        private readonly ChicagoFactory chicagoFactory;

        public ChicagoPizzaStore(ChicagoFactory chicagoFactory)
        {
            this.chicagoFactory = chicagoFactory;
        }

        public IPizza OrderPizza(string type)
        {
            var pizza = chicagoFactory.CreatePizza(type);

            // This is the issue here, different pizza stores can stop following the standard practice
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
