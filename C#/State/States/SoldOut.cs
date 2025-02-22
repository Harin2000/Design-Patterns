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
    }
}