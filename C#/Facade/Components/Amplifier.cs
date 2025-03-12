using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Components
{
    internal class Amplifier
    {
        private Tuner tuner;
        private StreamingPlayer player;
        public void On() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void Off() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void SetStreamingPlayer(StreamingPlayer player) { 
            Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}");
            this.player = player;
        }
        public void SetStereoSound() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void SetSurroundSound() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void SetTuner(Tuner tuner) { 
            Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}");
            this.tuner = tuner;
        }
        public void SetVolume(int volume) { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()} with param:{volume}"); }
    }
}
