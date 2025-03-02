using Command.VendorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class CeilingFanMedOnCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private int prevSpeed;
        public CeilingFanMedOnCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
            prevSpeed = ceilingFan.Speed;
        }
        public void Execute()
        {
            prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Medium();
        }

        public void Undo()
        {
            if (prevSpeed == 1) _ceilingFan.Low();
            else if (prevSpeed == 2) _ceilingFan.Medium();
            else if (prevSpeed == 3) _ceilingFan.High();
            else _ceilingFan.Off();
        }
    }
}
