using Command.VendorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class StereoOnWithCdCommand : ICommand
    {
        private Stereo _stereo;
        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.On(); _stereo.SetCd(); _stereo.setVolume(11);
        }

        public void Undo()
        {
            _stereo.Off(); 
        }
    }
}
