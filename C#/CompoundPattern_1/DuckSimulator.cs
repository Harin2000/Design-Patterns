using CompoundPattern_1.Factories;
using CompoundPattern_1.Quackables;

namespace CompoundPattern_1
{
    internal class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            IAbstractDuckFactory factory = new CountingDuckFactory();
            simulator.Simulate(factory);
        }

        void Simulate(IAbstractDuckFactory factory)
        {
            //IQuackable mallardDuck = new MallardDuck();
            //IQuackable redheadDuck = new RedheadDuck();
            //IQuackable duckCall = new DuckCall();
            //IQuackable rubberDuck = new RubberDuck();
            IQuackable redheadDuck = factory.CreateRedHeadDuck();
            IQuackable duckCall = factory.CreateDuckCall();
            IQuackable rubberDuck = factory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose()); //Don't want honk counts

            Console.WriteLine("Duck Simulator:");

            IQuackable mallardOne = factory.CreateMallardDuck();
            IQuackable mallardTwo = factory.CreateMallardDuck();
            IQuackable mallardThree = factory.CreateMallardDuck();
            IQuackable mallardFour = factory.CreateMallardDuck();

            Flock flockOfMallards = new Flock(new List<IQuackable>() { mallardOne, mallardTwo, mallardThree, mallardFour });
            Console.WriteLine("Simulating Flock of mallards:");
            Simulate(flockOfMallards);

            Flock flockOfDucks = new Flock(new List<IQuackable>() { redheadDuck, duckCall, rubberDuck, gooseDuck, flockOfMallards });
            Console.WriteLine("Simulating Flock of Ducks:");
            Simulate(flockOfDucks);

            Console.WriteLine($"Total quacks are:{DuckDecorator.GetQuacks()}");
        }

        void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
