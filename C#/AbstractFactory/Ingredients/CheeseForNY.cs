﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients
{
    internal class CheeseForNY : Cheese
    {
        public override void AddCheese()
        {
            Console.WriteLine($"Adding {this.GetType()}");
        }
    }
}
