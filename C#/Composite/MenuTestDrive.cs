using Composite.Menus;
using System.Security.Cryptography.X509Certificates;

namespace Composite
{
    internal class MenuTestDrive
    {
        static void Main(string[] args)
        {
            //var pcHouseMenu = new PancakeHouseMenu();
            //var dinerMenu = new DinerMenu();
            //var cafeMenu = new CafeMenu();
            //var menus = new List<IMenu> { pcHouseMenu, dinerMenu, cafeMenu };
            //var waitress = new Waitress(menus);
            //waitress.PrintMenu();

            MenuComponent pcHouseMenu = new Menu("Pancake House Menu", "Breakfast");
            MenuComponent dinerMenu = new Menu("Diner Menu", "Lunch");
            MenuComponent cafeMenu = new Menu("Cafe Menu", "Dinner");
            MenuComponent dessertMenu = new Menu("Dessert Menu", "Dessert of course!");

            pcHouseMenu.Add(new MenuItem("PC1", "PanCake1", false, 1.0));
            pcHouseMenu.Add(new MenuItem("PC2", "PanCake2", false, 2.0));
            pcHouseMenu.Add(new MenuItem("PC3", "PanCake3", false, 3.0));
            pcHouseMenu.Add(new MenuItem("PC4", "PanCake4", false, 4.0));

            cafeMenu.Add(new MenuItem("C1", "Cafe1", true, 1.0));
            cafeMenu.Add(new MenuItem("C2", "Cafe2", true, 2.0));
            cafeMenu.Add(new MenuItem("C3", "Cafe3", true, 3.0));
            cafeMenu.Add(new MenuItem("C4", "Cafe4", true, 4.0));

            MenuComponent allMenus = new Menu("All menus", "All menus combined.");

            allMenus.Add(pcHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("D1", "Diner1", true, 1.0));
            dinerMenu.Add(new MenuItem("D2", "Diner2", true, 2.0));
            dinerMenu.Add(new MenuItem("D3", "Diner3", false, 3.0));
            dinerMenu.Add(new MenuItem("D4", "Diner4", false, 4.0));
            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Dsrt1", "Dessert1", false, 1.0));
            dessertMenu.Add(new MenuItem("Dsrt2", "Dessert2", false, 2.0));
            dessertMenu.Add(new MenuItem("Dsrt3", "Dessert3", false, 3.0));

            Waitress waitress = new Waitress(allMenus);
            waitress.printMenu();
        }
    }
}
