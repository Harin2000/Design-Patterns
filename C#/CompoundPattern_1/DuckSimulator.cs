using CompoundPattern_1.Quackables;

namespace CompoundPattern_1
{
    internal class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            simulator.Simulate();
        }

        void Simulate()
        {
            //IQuackable mallardDuck = new MallardDuck();
            //IQuackable redheadDuck = new RedheadDuck();
            //IQuackable duckCall = new DuckCall();
            //IQuackable rubberDuck = new RubberDuck();
            IQuackable mallardDuck = new DuckDecorator(new MallardDuck());
            IQuackable redheadDuck = new DuckDecorator(new RedheadDuck());
            IQuackable duckCall = new DuckDecorator(new DuckCall());
            IQuackable rubberDuck = new DuckDecorator(new RubberDuck());
            IQuackable gooseDuck = new GooseAdapter(new Goose()); //Don't want honk counts

            Console.WriteLine("Duck Simulator:");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            Console.WriteLine($"Total quacks are:{DuckDecorator.GetQuacks()}");
        }

        void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
