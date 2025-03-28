﻿using CompoundPattern_1.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Quackables
{
    internal class Flock : IQuackable
    {
        List<IQuackable> quackers;

        public void NotifyObservers()
        {
            var enumerator = quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            var enumerator = quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.RegisterObserver(observer);
            }
        }
        public Flock(List<IQuackable> ducks)
        {
            this.quackers = ducks;
        }
        public void Quack()
        {
            //foreach (var duck in quackers) {
            //    duck.Quack();
            //}
            IEnumerator<IQuackable> iterator = quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                iterator.Current.Quack();
            }
        }
        public void AddDuck(IQuackable duck) { quackers.Add(duck); }
        public void RemoveDuck(IQuackable duck) { quackers.Remove(duck); }
    }
}
