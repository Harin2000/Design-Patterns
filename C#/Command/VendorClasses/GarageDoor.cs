using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Command.VendorClasses
{
    internal class GarageDoor
    {
        string name;
        public GarageDoor(string name)
        {
            this.name = name;
        }
        public void Up() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
        public void Down() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
        public void Stop() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
        public void LightOn() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
        public void LightOff() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
    }
}
