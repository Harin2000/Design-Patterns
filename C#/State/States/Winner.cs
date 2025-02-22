using System.Reflection;

namespace State.States
{
    internal class Winner : IState
    {
        private GumballMachine gumballMachine;

        public Winner(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine($"Dispensed two gumballs if present in the machine.");
            gumballMachine.gumballs -= 2;
            if (gumballMachine.gumballs > 0) gumballMachine.State = gumballMachine.NoQuarterState;
            else gumballMachine.State = gumballMachine.SoldOutState;
        }

        public void EjectQuarter()
        {
            Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{GetType()}.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{GetType()}.");
        }

        public void TurnCrank()
        {
            Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{GetType()}.");
        }
    }
}