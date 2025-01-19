namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.Quack();
            duck.Swim();
            duck.Fly();
            duck.Display();

            duck = new RedheadDuck();
            duck.Quack();
            duck.Swim();
            duck.Fly();
            duck.Display();

            duck = new RubberDuck();
            duck.Quack();
            duck.Swim();
            duck.Fly(); // this is what went wrong horribly
            duck.Display();
        }
    }
}
