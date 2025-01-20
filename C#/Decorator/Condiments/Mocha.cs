using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    internal class Mocha:Condiment
    {
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
            SetDescription();
        }
        public override int Cost()
        {
            return 3 + Beverage.Cost();
        }
        protected override void SetDescription()
        {
            Description = $"Description of the condiment:{this.GetType()} which is on top of the beverage:\n" +
                $"{Beverage.Description}\n";
        }
    }
}
