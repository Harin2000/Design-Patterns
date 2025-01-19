using Observer.Displays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface ISubject
    {
        void Add(IObserver toadd);
        void Remove(IObserver toremove);
        void Notify();
    }
}
