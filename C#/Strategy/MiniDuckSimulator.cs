using Strategy.Behaviors;
using Strategy.Behaviors.FlyBehavior;
using Strategy.Behaviors.QuackBehavior;
using Strategy.Ducks;
using System.Runtime.CompilerServices;

namespace Strategy
{
    internal class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.Quack();
            duck.Swim();
            duck.Fly();
            duck.Display();
            Console.WriteLine();

            duck = new RedheadDuck();
            duck.Quack();
            duck.Swim();
            duck.Fly();
            duck.Display();
            Console.WriteLine();

            duck = new RubberDuck();
            duck.Quack();
            duck.Swim();
            duck.Fly(); // this is what went wrong horribly
            duck.Display();
            Console.WriteLine();

            Console.WriteLine("Adding wings in rubber duck magically..");
            duck.flyBehavior = new FlyWithWings();
            duck.Fly();
            Console.WriteLine();

            Console.WriteLine("Rubber duck got teared, can't squak anymore...");
            duck.quackBehavior = new MuteQuack();
            duck.Quack();
        }
    }
}
