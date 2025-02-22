using System.Reflection;

namespace State.States
{
    internal class Winner : State
    {
        private GumballMachine gumballMachine;

        public Winner(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void Dispense()
        {
            Console.WriteLine($"Dispensed two gumballs if present in the machine.");
            gumballMachine.gumballs -= 2;
            if (gumballMachine.gumballs > 0) gumballMachine.State = gumballMachine.NoQuarterState;
            else gumballMachine.State = gumballMachine.SoldOutState;
        }
    }
}