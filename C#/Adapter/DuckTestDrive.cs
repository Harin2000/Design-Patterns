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
            testduck(duck);
            Console.WriteLine();

            Console.WriteLine("Testing wild turkey...");
            turkey.Fly();
            turkey.Gobble();
            Console.WriteLine();

            Console.WriteLine("Testing TurkeyAdapter...");
            testduck(turkeyAdapter);
        }

        static void testduck(IDuck ducktotest)
        {
            ducktotest.Fly();
            ducktotest.Quack();
        }
    }
}
