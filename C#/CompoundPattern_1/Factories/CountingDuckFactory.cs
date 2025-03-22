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
            return new DuckDecorator(new DuckCall());
        }

        public IQuackable CreateMallardDuck()
        {
            return new DuckDecorator(new MallardDuck());
        }

        public IQuackable CreateRedHeadDuck()
        {
            return new DuckDecorator(new RedheadDuck());
        }

        public IQuackable CreateRubberDuck()
        {
            return new DuckDecorator(new RubberDuck());
        }
    }
}
