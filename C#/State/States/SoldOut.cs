using System.Reflection;

namespace State.States
{
    internal class SoldOut : IState
    {
        private GumballMachine gumballMachine;

        public SoldOut(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{GetType()}.");
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