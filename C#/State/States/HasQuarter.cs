using System.Reflection;

namespace State.States
{
    internal class HasQuarter : IState
    {
        private GumballMachine gumballMachine;
        public Random Rand = new Random();
        public HasQuarter(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{GetType()}.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine($"Ejected the quarter.");
            gumballMachine.State = gumballMachine.NoQuarterState;
        }

        public void InsertQuarter()
        {
            Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{GetType()}.");
        }

        public void TurnCrank()
        {
            Console.WriteLine($"Turned the crank.");
            if (Rand.Next(10) == 0)
            {
                Console.WriteLine("We got a winner!");
                gumballMachine.State = gumballMachine.WinnerState;
            }
            else
            {
                Console.WriteLine("Not a winner.");
                gumballMachine.State = gumballMachine.SoldState;
            }
        }
    }
}