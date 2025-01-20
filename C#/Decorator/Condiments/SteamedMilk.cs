using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    internal class SteamedMilk : Condiment
    {
        public SteamedMilk(Beverage beverage)
        {
            Beverage = beverage;
            SetDescription();
        }
        public override int Cost()
        {
            return 1 + Beverage.Cost();
        }
        protected override void SetDescription()
        {
            Description = $"Description of the condiment:{this.GetType()} which is on top of the beverage:\n" +
                $"{Beverage.Description}\n";
        }
    }
}
