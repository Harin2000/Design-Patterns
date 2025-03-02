using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Command.VendorClasses
{
    internal class Light
    {
        string name;
        public Light(string name)
        {
            this.name = name;
        }
        public void On() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
        public void Off() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
    }
}
