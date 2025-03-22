using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Quackables
{
    internal class RubberDuck: IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak from rubber duck.");
        }
    }
}
