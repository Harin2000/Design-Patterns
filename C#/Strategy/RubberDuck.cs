using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class RubberDuck : Duck
    {
        internal override void Display()
        {
            Console.WriteLine($"Displaying {this.GetType()}");
        }
        internal override void Quack()
        {
            Console.WriteLine($"{this.GetType()} squaks...");
        }
    }
}
