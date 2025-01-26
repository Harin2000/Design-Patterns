using AbstractFactory.Ingredients;
using AbstractFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStores
{
    internal class NYPizzaStore:PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            // TODO: DOUBT: Why are we initializing new factory for each CreatePizza call? Instead, this should have been in the ctor, right?
            IPizzaIngredientFactory nyIngredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    return new CheesePizza(nyIngredientFactory);
                case "greek":
                    return new GreekPizza(nyIngredientFactory);
                case "pepperoni":
                    return new PepperoniPizza(nyIngredientFactory);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}