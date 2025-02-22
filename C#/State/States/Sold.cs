using System.Reflection;

namespace State.States
{
    internal class Sold : IState
    {
        private GumballMachine gumballMachine;
        public Sold(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine($"Dispensed a gumball.");
            --gumballMachine.gumballs;
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