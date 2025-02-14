using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    enum State
    {
        SOLD_OUT = 0,
        NO_QUARTER,
        HAS_QUARTER,
        SOLD
    }
    internal class GumballMachine
    {
        private int gumballs;
        private State state;
        public GumballMachine(int gumballs)
        {
            this.gumballs = gumballs;
            state = State.NO_QUARTER;
        }
        public void InsertQuarter()
        {
            switch (state) {
                case State.NO_QUARTER:
                    Console.WriteLine("Inserted a quarter.");
                    state = State.HAS_QUARTER; 
                    break;
                case State.SOLD_OUT:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                case State.HAS_QUARTER:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                case State.SOLD:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                default:
                    Console.WriteLine($"Invalid state: {state}");
                    break;
            }
        }
        public void EjectQuarter()
        {
            switch (state)
            {
                case State.NO_QUARTER:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                case State.SOLD_OUT:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                case State.HAS_QUARTER:
                    Console.WriteLine($"Ejected the quarter.");
                    state = State.NO_QUARTER;
                    break;
                case State.SOLD:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                default:
                    Console.WriteLine($"Invalid state: {state}");
                    break;
            }
        }
        public void TurnCrank()
        {
            switch (state)
            {
                case State.NO_QUARTER:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                case State.SOLD_OUT:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                case State.HAS_QUARTER:
                    Console.WriteLine($"Turned the crank.");
                    state = State.SOLD;
                    break;
                case State.SOLD:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                default:
                    Console.WriteLine($"Invalid state: {state}");
                    break;
            }
        }
        public void Dispense()
        {
            switch (state)
            {
                case State.NO_QUARTER:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                case State.SOLD_OUT:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                case State.HAS_QUARTER:
                    Console.WriteLine($"Invalid action:{MethodBase.GetCurrentMethod().Name} for state:{state}.");
                    break;
                case State.SOLD:
                    Console.WriteLine($"Dispensed a gumball.");
                    --gumballs;
                    if(gumballs>0) state = State.NO_QUARTER;
                    else state = State.SOLD_OUT;
                    break;
                default:
                    Console.WriteLine($"Invalid state: {state}");
                    break;
            }
        }
    }
}
