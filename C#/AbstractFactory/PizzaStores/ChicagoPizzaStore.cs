using AbstractFactory.Ingredients;
using AbstractFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStores
{
    internal class ChicagoPizzaStore:PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            // TODO: DOUBT: Why are we initializing new factory for each CreatePizza call? Instead, this should have been in the ctor, right?
            IPizzaIngredientFactory chicagoIngredientFactory = new ChicagoPizzaIngredientFactory();
            switch (type)
            {
                case "cheese":
                    return new CheesePizza(chicagoIngredientFactory);
                case "greek":
                    return new GreekPizza(chicagoIngredientFactory);
                case "pepperoni":
                    return new PepperoniPizza(chicagoIngredientFactory);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
