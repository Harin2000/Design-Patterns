using Composite.Menus;

namespace Composite
{
    internal class MenuTestDrive
    {
        static void Main(string[] args)
        {
            var pcHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var cafeMenu = new CafeMenu();
            var menus = new List<IEnumerable<MenuItem>> { pcHouseMenu, dinerMenu, cafeMenu };
            var waitress = new Waitress(menus);
            waitress.PrintMenu();
        }
    }
}
