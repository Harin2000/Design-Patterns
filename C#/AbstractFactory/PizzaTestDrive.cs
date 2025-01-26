using AbstractFactory.PizzaStores;

namespace AbstractFactory
{
    internal class PizzaTestDrive
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();

            var nyCheesePizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine();

            var nyGreekPizza = nyPizzaStore.OrderPizza("greek");
            Console.WriteLine();

            var nyPepperoniPizza = nyPizzaStore.OrderPizza("pepperoni");
            Console.WriteLine();
            Console.WriteLine();

            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

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
