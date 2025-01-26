using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients
{
    internal class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new CheeseForChicago();
        }

        public Sauce createSauce()
        {
            return new SauceForChicago();
        }
    }
}
