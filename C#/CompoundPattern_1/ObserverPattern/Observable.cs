using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.ObserverPattern
{
    internal class Observable : IQuackObservable
    {
        List<IObserver> observers = new List<IObserver>();
        IQuackObservable duck;
        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
        }
        public void NotifyObservers()
        {
            var enumerator = observers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.Update(duck);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}
