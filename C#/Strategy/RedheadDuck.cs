﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class RedheadDuck : Duck
    {
        internal override void Display()
        {
            Console.WriteLine($"Displaying {this.GetType()}");
        }
    }
}
