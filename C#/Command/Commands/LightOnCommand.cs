using Command.VendorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class LightOnCommand : ICommand
    {
        private Light _light;
        public LightOnCommand(Light light) {
            _light = light;
        }
        public void execute()
        {
            _light.On();
        }
        public void Undo()
        {
            _light.Off();
        }
    }
}
