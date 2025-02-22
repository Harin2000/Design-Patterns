using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    internal class NoQuarter : IState
    {
        GumballMachine gumballMachine;
        public NoQuarter(GumballMachine gumballMachine)
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
            Console.WriteLine("Inserted a quarter.");
            gumballMachine.State = gumballMachine.HasQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{GetType()}.");
        }
    }
}
