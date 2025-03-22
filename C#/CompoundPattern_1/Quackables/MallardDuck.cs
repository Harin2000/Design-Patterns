using CompoundPattern_1.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Quackables
{
    internal class MallardDuck: IQuackable
    {
        Observable observable;
        public MallardDuck()
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
            Console.WriteLine("Quack from mallard.");
            NotifyObservers();
        }
    }
}
