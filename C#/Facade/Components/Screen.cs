using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Components
{
    internal class Screen
    {
        public void Up() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void Down() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
    }
}
