using Command.VendorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class GarageDoorUpCommand : ICommand
    {
        private GarageDoor _garageDoor;
        public GarageDoorUpCommand(GarageDoor garageDoor) { 
            _garageDoor = garageDoor;
        }
        public void execute()
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
        }
    }
}
