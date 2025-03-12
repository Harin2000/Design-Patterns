using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if(CustomerWantsCondiments())
            AddCondiments();
        }
        public void BoilWater() { Console.WriteLine("Boiling water..."); }
        public abstract void Brew();
        public void PourInCup() { Console.WriteLine($"Pouring in a cup..."); }
        public abstract void AddCondiments();
        public virtual bool CustomerWantsCondiments() { return true; }
    }
}
