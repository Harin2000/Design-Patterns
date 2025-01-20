using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    internal abstract class Condiment:Beverage
    {
        public Beverage Beverage { get; protected set; }
        protected abstract void SetDescription();
    }
}
