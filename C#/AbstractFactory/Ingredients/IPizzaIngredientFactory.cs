using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients
{
    internal interface IPizzaIngredientFactory
    {
        public Sauce createSauce();
        public Cheese createCheese();
    }
}
