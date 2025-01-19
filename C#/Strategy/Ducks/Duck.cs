using Strategy.Behaviors.FlyBehavior;
using Strategy.Behaviors.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    internal abstract class Duck
    {
        //internal virtual void Quack()
        internal void Quack()
        {
            //Console.WriteLine($"{this.GetType()} is quacking..");
            Console.Write($"{this.GetType()} "); quackBehavior.Quack();
        }
        internal void Swim()
        {
            Console.WriteLine($"{GetType()} is swimming...");
        }
        internal abstract void Display();

        // Added fly method
        internal void Fly()
        {
            //Console.WriteLine($"{this.GetType()} is flying...");
            Console.Write($"{this.GetType()} "); flyBehavior.Fly();
        }

        // Resolving the horrible problem
        internal IFlyBehavior flyBehavior { get; set; }
        internal IQuackBehavior quackBehavior { get; set; }
    }
}
