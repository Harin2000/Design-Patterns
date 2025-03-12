using Facade.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class HomeTheaterFacade
    {
        Amplifier amp;
        Tuner tuner;
        StreamingPlayer player;
        Projector projector;
        TheaterLights lights;
        Screen screen;
        PopcornPopper popper;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, StreamingPlayer player, Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.player = player;
            this.projector = projector;
            this.lights = lights;
            this.screen = screen;
            this.popper = popper;
        }
        public void WatchMovie()
        {
            Console.WriteLine("Get ready to watch a movie...");
            popper.On();
            popper.Pop();
            lights.Dim();
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amp.On();
            amp.SetStreamingPlayer(player);
            amp.SetSurroundSound();
            amp.SetVolume(5);
            player.On();
            player.Play("3 idiots");
        }
        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amp.Off();
            player.Stop();
            player.Off();
        }
    }
}
