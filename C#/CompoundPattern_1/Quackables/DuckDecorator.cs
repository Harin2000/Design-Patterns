using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Quackables
{
    internal class DuckDecorator : IQuackable
    {
        IQuackable duck;
        static int numberOfQuacks = 0;
        public static int GetQuacks() { return numberOfQuacks; }
        public DuckDecorator(IQuackable duck)
        {
            this.duck = duck;
        }
        public void Quack()
        {
            duck.Quack();
            ++numberOfQuacks;
        }
    }
}
