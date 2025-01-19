using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behaviors.QuackBehavior
{
    internal class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine(" squaks.."); ;
        }
    }
}
