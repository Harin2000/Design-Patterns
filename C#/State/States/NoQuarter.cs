using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    internal class NoQuarter : State
    {
        GumballMachine gumballMachine;
        public NoQuarter(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("Inserted a quarter.");
            gumballMachine.State = gumballMachine.HasQuarterState;
        }
    }
}
