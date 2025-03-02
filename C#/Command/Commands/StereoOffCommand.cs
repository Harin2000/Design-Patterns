using Command.VendorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class StereoOffCommand : ICommand
    {
        private Stereo _stereo;
        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On(); _stereo.SetCd(); _stereo.setVolume(11);
        }
    }
}
