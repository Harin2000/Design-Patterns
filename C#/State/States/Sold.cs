using System.Reflection;

namespace State.States
{
    internal class Sold : State
    {
        private GumballMachine gumballMachine;
        public Sold(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public override void Dispense()
        {
            Console.WriteLine($"Dispensed a gumball.");
            --gumballMachine.gumballs;
            if (gumballMachine.gumballs > 0) gumballMachine.State = gumballMachine.NoQuarterState;
            else gumballMachine.State = gumballMachine.SoldOutState;
        }
    }
}