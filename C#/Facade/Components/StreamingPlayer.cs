using System.Reflection;

namespace Facade.Components
{
    internal class StreamingPlayer
    {
        private Amplifier amplifier;
        public StreamingPlayer(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }
        public void On() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void Off() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void Pause() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void Play(string movie) { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()} with param:{movie}"); }
        public void SetSurroundAudio() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void SetTwoChannelAudio() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name} in {GetType()}"); }
        public void Stop() { Console.WriteLine($"Executing {MethodBase.GetCurrentMethod()} in {GetType().Name}"); }
    }
}