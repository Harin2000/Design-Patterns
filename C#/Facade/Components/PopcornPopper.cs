using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Components
{
    internal class PopcornPopper
    {
        public void On() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void Off() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void Pop() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
    }
}
