using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Tea : CaffeineBeverage
    {
        public override void AddCondiments() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} inside {GetType()}"); }

        public override void Brew() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} inside {GetType()}"); }
        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Enter 'y' & enter if you want condiments, otherwise just press enter:");
            string read = Console.ReadLine();
            if (read == "y")
            {
                return true;
            }
            else return false;
        }
    }
}
