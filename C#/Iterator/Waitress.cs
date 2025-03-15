using Iterator.Iterators;
using Iterator.Menus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Waitress
    {
        PancakeHouseMenu panCakeMenu;
        DinerMenu dinerMenu;
        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.panCakeMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }
        public void PrintMenu()
        {
            //List<MenuItem> pcMenuItems = panCakeMenu.GetMenuItems();
            //foreach(var item in pcMenuItems)
            //{
            //    Console.WriteLine(item);
            //}
            PrintMenu(panCakeMenu.CreateIterator());

            //var dinerMenuItems = dinerMenu.GetMenuItems();
            //foreach (var item in dinerMenuItems)
            //{
            //    Console.WriteLine(item);
            //}
            PrintMenu(dinerMenu.CreateIterator());
        }
        private void PrintMenu(IEnumerator enumerator)
        {
            do{ Console.WriteLine(enumerator.Current); }while(enumerator.MoveNext());
            Console.WriteLine();
        }

        // NOTE: PrintBreakfastMenu(), PrintLunchMenu(), PrintVegetarianMenu(), IsItemVegetarian(name) will all be a variation to the above
    }
}
