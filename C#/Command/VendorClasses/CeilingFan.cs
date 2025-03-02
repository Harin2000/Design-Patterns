using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Command.VendorClasses
{
    internal class CeilingFan
    {
        string name;
        public int Speed { private set; get; }
        public CeilingFan(string name)
        {
            this.name = name;
        }
        public void High()
        {
            Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name} with existing speed:{Speed}");
            Speed = 3;
        }
        public void Medium()
        {
            Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name} with existing speed:{Speed}");
            Speed = 2;
        }
        public void Low()
        {
            Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name} with existing speed:{Speed}");
            Speed = 1;
        }
        public void Off()
        {
            Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name} with existing speed:{Speed}");
            Speed = 0;
        }
        public int GetSpeed()
        {
            Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name} with existing speed:{Speed}");
            return Speed;
        }
    }
}
