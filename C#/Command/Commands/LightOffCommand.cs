using Command.VendorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class LightOffCommand : ICommand
    {
        private Light _light;
        public LightOffCommand(Light light) { 
            _light = light;
        }
        public void execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}
