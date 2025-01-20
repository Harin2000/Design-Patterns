namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cost = 0;
            var hbd = new HourseBlend(); Console.WriteLine(hbd.Description); cost += hbd.Cost();
            var drt = new DarkRoast(); Console.WriteLine(drt.Description); cost += drt.Cost();
            var dcf = new Decaf(); Console.WriteLine(dcf.Description); cost += dcf.Cost();
            var esp = new Espresso(); Console.WriteLine(esp.Description); cost += esp.Cost();
            Console.WriteLine(cost);
        }
    }
}
