using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Decaf : Beverage
    {
        public Decaf() { Description = $"{this.GetType()} description."; }
        public override int Cost()
        {
            return 140;
        }
    }
}
