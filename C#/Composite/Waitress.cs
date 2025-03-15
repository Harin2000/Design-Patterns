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
        List<IMenu> menus;
        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }
        public void PrintMenu()
        {
            IEnumerator<IMenu> menusEnum = menus.GetEnumerator();

            while (menusEnum.MoveNext())
            {
                IEnumerator<MenuItem> menuEnum = menusEnum.Current.GetEnumerator();
                PrintMenu(menuEnum);
            }
        }
        private void PrintMenu(IEnumerator<MenuItem> enumerator)
        {
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine();
        }

        // NOTE: PrintBreakfastMenu(), PrintLunchMenu(), PrintVegetarianMenu(), IsItemVegetarian(name) will all be a variation to the above
    }
}
