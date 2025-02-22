using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //enum State
    //{
    //    SOLD_OUT = 0,
    //    NO_QUARTER,
    //    HAS_QUARTER,
    //    SOLD,
    //    WINNER
    //}
    internal class GumballMachine
    {
        public int gumballs;
        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }
        public IState WinnerState { get; private set; }

        public IState State { get; set; }
        public GumballMachine(int gumballs)
        {
            SoldOutState = new SoldOut(this);
            NoQuarterState = new NoQuarter(this);
            HasQuarterState = new HasQuarter(this);
            SoldState = new Sold(this);
            WinnerState = new Winner(this);

            this.gumballs = gumballs;
            if (this.gumballs > 0) State = NoQuarterState;
            else State = SoldOutState;
        }
        public void InsertQuarter()
        {
            State.InsertQuarter();
        }
        public void EjectQuarter()
        {
            State.EjectQuarter();
        }
        public void TurnCrank()
        {
            State.TurnCrank();
        }
        public void Dispense()
        {
            State.Dispense();
        }
    }
}
