using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Components
{
    internal class TheaterLights
    {
        public void On() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void Off() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void Dim() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
    }
}
