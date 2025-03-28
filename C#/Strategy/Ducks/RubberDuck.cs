﻿using Strategy.Behaviors.FlyBehavior;
using Strategy.Behaviors.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    internal class RubberDuck : Duck
    {
        internal override void Display()
        {
            Console.WriteLine($"Displaying {GetType()}");
        }
        //internal override void Quack()
        //{
        //    Console.WriteLine($"{this.GetType()} squaks...");
        //}

        internal RubberDuck()
        {
            this.flyBehavior = new FlyNoWay();
            this.quackBehavior = new Squeak();
        }
    }
}
