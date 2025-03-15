using Composite.Iterators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Menus
{
    internal class DinerMenu : IMenu
    {
        static readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;
        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("D1", "D1_Desc", true, 1.0);
            AddItem("D2", "D2_Desc", true, 2.0);
            AddItem("D3", "D3_Desc", false, 3.0);
            AddItem("D4", "D4_Desc", false, 4.0);
        }
        public void AddItem(string name, string desc, bool veg, double price)
        {
            var menuItem = new MenuItem(name, desc, veg, price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("DinerMenu is full!");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                ++numberOfItems;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<MenuItem> IEnumerable<MenuItem>.GetEnumerator()
        {
            return new DinerMenuIterator<MenuItem>(menuItems);
        }
    }
}
