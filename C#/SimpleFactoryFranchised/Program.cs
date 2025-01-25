using SimpleFactoryFranchised.Factories;
using SimpleFactoryFranchised.PizzaStores;

namespace SimpleFactoryFranchised
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nyFactory = new NYFactory();
            var nyPizzaStore = new NYPizzaStore(nyFactory);

            var nyCheesePizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine();

            var nyGreekPizza = nyPizzaStore.OrderPizza("greek");
            Console.WriteLine();

            var nyPepperoniPizza = nyPizzaStore.OrderPizza("pepperoni");
            Console.WriteLine();
            Console.WriteLine();

            var chicagoFactory = new ChicagoFactory();
            var chicagoPizzaStore = new ChicagoPizzaStore(chicagoFactory);

            var chicagoCheesePizza = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine();

            var chicagoGreekPizza = chicagoPizzaStore.OrderPizza("greek");
            Console.WriteLine();

            var chicagoPepperoniPizza = chicagoPizzaStore.OrderPizza("pepperoni");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

