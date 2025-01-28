using System.Collections.Concurrent;

namespace Singleton
{
    internal class Program
    {
        private static ConcurrentDictionary<ChocolateBoiler, int> chocos = new ConcurrentDictionary<ChocolateBoiler, int> ();

        static void Main(string[] args)
        {
            Parallel.For(0, 10, (_) => { FillBoilDrain(); });
            //int boilerInstances = ChocolateBoiler.counter;
            Console.WriteLine();
            //Console.WriteLine($"Number of boiler instances:{boilerInstances}");
            //if(boilerInstances != 1)
            //{
            //    Console.WriteLine("SINGLETON IS NOT PROPERLY IMPLEMENTED!!");
            //}
            Console.WriteLine(chocos.Count);
        }

        static void FillBoilDrain()
        {
            ChocolateBoiler choco = ChocolateBoiler.getInstance();
            Console.WriteLine($"Is boiler empty? {choco.IsEmpty()}");
            Console.WriteLine($"Is boiler boiled? {choco.IsBoiled()}");
            Console.WriteLine("Boiling...");
            choco.Boil();
            Console.WriteLine($"Is boiler empty? {choco.IsEmpty()}");
            Console.WriteLine($"Is boiler boiled? {choco.IsBoiled()}");
            Console.WriteLine("Oops, can't boil without filling it!");
            choco.Fill();
            Console.WriteLine($"Is boiler empty? {choco.IsEmpty()}");
            Console.WriteLine($"Is boiler boiled? {choco.IsBoiled()}");
            Console.WriteLine("Boiling...");
            choco.Boil();
            Console.WriteLine($"Is boiler empty? {choco.IsEmpty()}");
            Console.WriteLine($"Is boiler boiled? {choco.IsBoiled()}");
            Console.WriteLine("Draining...");
            choco.Drain();
            Console.WriteLine($"Is boiler empty? {choco.IsEmpty()}");
            Console.WriteLine($"Is boiler boiled? {choco.IsBoiled()}");

            chocos.TryAdd(choco, 0);
        }
    }
}
