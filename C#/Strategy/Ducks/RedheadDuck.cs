using Strategy.Behaviors.FlyBehavior;
using Strategy.Behaviors.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    internal class RedheadDuck : Duck
    {
        internal override void Display()
        {
            Console.WriteLine($"Displaying {GetType()}");
        }

        internal RedheadDuck()
        {
            this.flyBehavior = new FlyWithWings();
            this.quackBehavior = new QuackNormally();
        }
    }
}
