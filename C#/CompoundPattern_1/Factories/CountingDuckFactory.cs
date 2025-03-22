using CompoundPattern_1.Quackables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Factories
{
    internal class CountingDuckFactory : IAbstractDuckFactory
    {
        public IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public IQuackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public IQuackable CreateRedHeadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
