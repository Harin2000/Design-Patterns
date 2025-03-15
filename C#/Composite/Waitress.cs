using Composite.Iterators;
using Composite.Menus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Waitress
    {
        //IEnumerable<MenuItem> panCakeMenu;
        //IEnumerable<MenuItem> dinerMenu;
        //IEnumerable<MenuItem> cafeMenu;
        List<IMenu> menus;
        public Waitress(List<IMenu> menus)
        {
            //this.panCakeMenu = pancakeHouseMenu;
            //this.dinerMenu = dinerMenu;
            //this.cafeMenu = cafeMenu;
            this.menus = menus;
        }
        public void PrintMenu()
        {
            foreach (var menu in menus) {
                PrintMenu(menu.GetEnumerator());
            }
        }
        private void PrintMenu(IEnumerator<MenuItem> enumerator)
        {
            do{ Console.WriteLine(enumerator.Current); } while(enumerator.MoveNext());
            Console.WriteLine();
        }

        // NOTE: PrintBreakfastMenu(), PrintLunchMenu(), PrintVegetarianMenu(), IsItemVegetarian(name) will all be a variation to the above
    }
}
