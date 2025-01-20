using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Espresso : Beverage
    {
        public Espresso() { Description = $"{this.GetType()} description."; }
        public override int Cost()
        {
            return 160;
        }
    }
}
