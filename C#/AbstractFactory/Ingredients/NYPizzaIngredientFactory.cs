using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients
{
    internal class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new CheeseForNY();
        }

        public Sauce createSauce()
        {
            return new SauceForNY();
        }
    }
}
