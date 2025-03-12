namespace TemplateMethod
{
    internal class BeverageTestDrive
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            tea.PrepareRecipe();
            Console.WriteLine();

            var coffee = new Coffee();
            coffee.PrepareRecipe();
            Console.WriteLine();
        }
    }
}
