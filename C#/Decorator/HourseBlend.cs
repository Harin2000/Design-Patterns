using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class HourseBlend : Beverage
    {
        public HourseBlend() { Description = $"{this.GetType()} description."; }
        public override int Cost()
        {
            return 100;
        }
    }
}
