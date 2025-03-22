using CompoundPattern_1.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Quackables
{
    internal class QuackCounter : IQuackable
    {
        Observable observable;
        public void NotifyObservers()
        {
            duck.NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            duck.RegisterObserver(observer);
        }
        IQuackable duck;
        static int numberOfQuacks = 0;
        public static int GetQuacks() { return numberOfQuacks; }
        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }
        public void Quack()
        {
            duck.Quack();
            ++numberOfQuacks;
        }
    }
}
