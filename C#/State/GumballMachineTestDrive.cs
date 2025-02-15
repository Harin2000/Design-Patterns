namespace State
{
    internal class GumballMachineTestDrive
    {
        static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(3);
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.Dispense();
            // Insert quarter
            gumballMachine.InsertQuarter();
            gumballMachine.Dispense();
            gumballMachine.InsertQuarter();
            // Eject quarter
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();
            // Insert quarter
            gumballMachine.InsertQuarter();
            // Turn crank
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            // Dispense
            gumballMachine.Dispense();
            // Insert, TurnCrank, Dispense
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.Dispense();
            // Insert, TurnCrank, Dispense
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.Dispense();
            // All Invalid
            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.Dispense();
        }
    }
}
