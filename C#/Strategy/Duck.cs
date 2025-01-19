using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class Duck
    {
        internal virtual void Quack()
        {
            Console.WriteLine($"{this.GetType()} is quacking..");
        }
        internal void Swim()
        {
            Console.WriteLine($"{this.GetType()} is swimming...");
        }
        internal abstract void Display();
        

        // Added fly method
        internal void Fly()
        {
            Console.WriteLine($"{this.GetType()} is flying...");
        }
    }
}
