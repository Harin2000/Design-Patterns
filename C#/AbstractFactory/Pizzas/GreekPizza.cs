using AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizzas
{
    internal class GreekPizza : Pizza
    {
        public GreekPizza(IPizzaIngredientFactory ingredientFactory) {
            pizzaIngredientFactory = ingredientFactory;
        }

        public override void Bake()
        {
            Console.WriteLine($"Baking {this.GetType()}");
        }

        public override void Box()
        {
            Console.WriteLine($"Boxing {this.GetType()}");
        }

        public override void Cut()
        {
            Console.WriteLine($"Cutting {this.GetType()}");
        }

        public override void Prepare()
        {
            Sauce = pizzaIngredientFactory.createSauce();
            Cheese = pizzaIngredientFactory.createCheese();
            Console.WriteLine($"Preparing {this.GetType()} with ingredient: {Sauce.GetType()} & {Cheese.GetType()}");
        }
    }
}
