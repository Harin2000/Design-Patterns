using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Duck
{
    internal class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine($"Mallard duck flying...");
        }

        public void Quack()
        {
            Console.WriteLine("Mallard duck quacking...");
        }
    }
}
