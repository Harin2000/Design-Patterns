using Decorator.Condiments;

namespace Decorator
{
    internal class StarBuzzCoffee
    {
        static void Main(string[] args)
        {
            var cost = 0;
            var hbd = new HourseBlend(); Console.WriteLine(hbd.Description); cost += hbd.Cost();
            var drt = new DarkRoast(); Console.WriteLine(drt.Description); cost += drt.Cost();
            var dcf = new Decaf(); Console.WriteLine(dcf.Description); cost += dcf.Cost();
            var esp = new Espresso(); Console.WriteLine(esp.Description); cost += esp.Cost();
            Console.WriteLine($"Total cost of all the beverages:{cost}"); // 100 + 120 + 140 + 160 = 520
            Console.WriteLine();

            // After adding condiments.
            var hbdWithMilk = new SteamedMilk(hbd);
            var hbdWithMilkAndSoy = new Soy(hbdWithMilk);
            var hbdWithAllCond = new Mocha(hbdWithMilkAndSoy);
            Console.WriteLine($"Cost of HouseBlend with StreamedMilk, Soy & Mocha:{hbdWithAllCond.Cost()}"); // 3 + 2 + 1 + 100 = 106
            Console.WriteLine(hbdWithAllCond.Description);
            Console.WriteLine();
        }
    }
}
