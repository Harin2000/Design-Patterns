using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Turkey
{
    internal class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("WildTurkey flying...");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobbling...");
        }
    }
}
