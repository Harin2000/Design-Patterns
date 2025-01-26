using AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal abstract class Pizza
    {
        public IPizzaIngredientFactory pizzaIngredientFactory { get; protected set; }

        protected Sauce Sauce { get; set; }
        protected Cheese Cheese { get; set; }

        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}
