using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients
{
    internal class SauceForNY : Sauce
    {
        public override void AddSauce()
        {
            Console.WriteLine($"Adding {this.GetType()}");
        }
    }
}
