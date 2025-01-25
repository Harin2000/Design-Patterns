namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simpleFactory = new SimplePizzaFactory();
            var pizzaStore = new PizzaStore(simpleFactory);

            var cheesePizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine();

            var greekPizza = pizzaStore.OrderPizza("greek");
            Console.WriteLine();

            var pepperoniPizza = pizzaStore.OrderPizza("pepperoni");
            Console.WriteLine();
        }
    }
}
