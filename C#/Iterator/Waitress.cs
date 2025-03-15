using Iterator.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Waitress
    {
        public void PrintMenu()
        {
            var panCakeMenu = new PancakeHouseMenu();
            List<MenuItem> pcMenuItems = panCakeMenu.GetMenuItems();
            foreach(var item in pcMenuItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var dinerMenu = new DinerMenu();
            var dinerMenuItems = dinerMenu.GetMenuItems();
            foreach (var item in dinerMenuItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        // NOTE: PrintBreakfastMenu(), PrintLunchMenu(), PrintVegetarianMenu(), IsItemVegetarian(name) will all be a variation to the above
    }
}
