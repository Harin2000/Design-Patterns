using System.Reflection;

namespace State.States
{
    internal class SoldOut : State
    {
        private GumballMachine gumballMachine;

        public SoldOut(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public override void Refill(int gumballs)
        {
            Console.WriteLine($"Refilling the gumball machine with {gumballs} gumballs.");
            gumballMachine.gumballs = gumballs;
            gumballMachine.State = gumballMachine.NoQuarterState;
        }
    }
}