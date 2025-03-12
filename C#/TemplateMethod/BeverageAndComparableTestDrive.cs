namespace TemplateMethod
{
    internal class BeverageAndComparableTestDrive
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            tea.PrepareRecipe();
            Console.WriteLine();

            var coffee = new Coffee();
            coffee.PrepareRecipe();
            Console.WriteLine();

            List<Duck> ducks = new List<Duck>() { new("a", 7), new("b", 8), new("c", 5), new("d", 4), new("e",6)};
            ducks.Sort();
            foreach (var duck in ducks) {
                Console.WriteLine($"{duck}");
            }
            /*
             * b:8
             * a:7
             * e:6
             * c:5
             * d:4
             */

            // TODO: Add JFrame.paint(Graphics graphics) equivalent here.
        }
    }
}
