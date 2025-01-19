using Strategy.Behaviors.FlyBehavior;
using Strategy.Behaviors.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    internal class MallardDuck : Duck
    {
        internal override void Display()
        {
            Console.WriteLine($"Displaying {GetType()}");
        }

        internal MallardDuck()
        {
            // TOBEIMPROVED: Acc. to the book, we'll improve here: By avoidiing the concrete implementation?
            this.flyBehavior = new FlyWithWings();
            this.quackBehavior = new QuackNormally();
        }
    }
}
