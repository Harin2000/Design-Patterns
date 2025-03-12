using Adapter.Duck;
using Adapter.Turkey;

namespace Adapter
{
    internal class DuckTestDrive
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();

            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("Testing duck...");
            duck.Fly();
            duck.Quack();

            Console.WriteLine("Testing wild turkey...");
            turkey.Fly();
            turkey.Gobble();

            Console.WriteLine("Testing TurkeyAdapter...");
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        }
    }
}
