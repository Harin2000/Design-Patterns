using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Command.VendorClasses
{
    internal class Stereo
    {
        string name;
        public Stereo(string name)
        {
            this.name = name;
        }
        public void On() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
        public void Off() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
        public void SetCd() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
        public void setDvd() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
        public void setRadio() { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
        public void setVolume(int value) { Console.WriteLine($"Executing:{MethodBase.GetCurrentMethod().Name} on the Vendor class:{GetType()} with name:{name}"); }
    }
}
