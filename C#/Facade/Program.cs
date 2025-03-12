namespace Facade
{
    using Components;
    internal class Program
    {
        static void Main(string[] args)
        {
            var amp = new Amplifier();
            var tuner = new Tuner(amp);
            var player = new StreamingPlayer(amp);
            var projector = new Projector(player);
            var lights = new TheaterLights();
            var screen = new Screen();
            var popper = new PopcornPopper();
            var homeTheaterFacade = new HomeTheaterFacade(amp, tuner, player, projector, lights, screen, popper);
            homeTheaterFacade.WatchMovie();
            Console.WriteLine();
            homeTheaterFacade.EndMovie();
            Console.WriteLine();
        }
    }
}
