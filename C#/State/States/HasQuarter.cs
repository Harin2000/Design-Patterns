using System.Reflection;

namespace State.States
{
    internal class HasQuarter : State
    {
        private GumballMachine gumballMachine;
        public Random Rand = new Random();
        public HasQuarter(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void EjectQuarter()
        {
            Console.WriteLine($"Ejected the quarter.");
            gumballMachine.State = gumballMachine.NoQuarterState;
        }

        public override void TurnCrank()
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