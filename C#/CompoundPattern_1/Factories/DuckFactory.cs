using CompoundPattern_1.Quackables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Factories
{
    internal class DuckFactory : IAbstractDuckFactory
    {
        public IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public IQuackable CreateRedHeadDuck()
        {
            return new RedheadDuck();
        }

        public IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
