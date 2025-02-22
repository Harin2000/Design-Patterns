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
            Console.WriteLine();

            // Insert, TurnCrank, Dispense
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.Dispense();
            Console.WriteLine();
            // Insert, TurnCrank, Dispense
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.Dispense();
            Console.WriteLine();
            // All Invalid
            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.Dispense();

            Console.WriteLine();
            Console.WriteLine("Attempting the full flow 10 times...");
            // Full flow 10 times:
            gumballMachine = new GumballMachine(10);
            for (int i = 0; i < 11; i++)
            {
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
                gumballMachine.Dispense();
            }
        }
    }
}
