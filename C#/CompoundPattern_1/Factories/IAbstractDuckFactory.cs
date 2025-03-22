using CompoundPattern_1.Quackables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Factories
{
    internal interface IAbstractDuckFactory
    {
        IQuackable CreateMallardDuck();
        IQuackable CreateRedHeadDuck();
        IQuackable CreateDuckCall();
        IQuackable CreateRubberDuck();
        // TODO: Why is this method chosen in book?
        // Is this abstract factory?
        // An issue I see here is that whenever a new duck is added, interface and all the implementations of this will be needed to be changed.
    }
}
