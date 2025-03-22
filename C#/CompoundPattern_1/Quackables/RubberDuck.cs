using CompoundPattern_1.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Quackables
{
    internal class RubberDuck: IQuackable
    {
        Observable observable;
        public RubberDuck()
        {
            observable = new Observable(this);
        }
        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
        public void Quack()
        {
            Console.WriteLine("Squeak from rubber duck.");
            NotifyObservers();
        }
    }
}
