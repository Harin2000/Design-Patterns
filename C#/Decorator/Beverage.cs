using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class Beverage
    {
        public string Description {  get; protected set; }
        public abstract int Cost();
    }
}
