using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Coffee : CaffeineBeverage
    {
        public override void AddCondiments() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} inside {GetType()}"); }

        public override void Brew() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} inside {GetType()}"); }
    }
}
