using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.ObserverPattern
{
    internal interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}
