using CompoundPattern_1.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Quackables
{
    internal class GooseAdapter : IQuackable
    {
        Observable observable;
        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
        Goose goose;
        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            observable = new Observable(this);
        }
        public void Quack()
        {
            goose.Honk();
            NotifyObservers();
        }
    }
}
