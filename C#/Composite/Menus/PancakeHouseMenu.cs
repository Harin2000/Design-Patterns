using Composite.Iterators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Menus
{
    internal class PancakeHouseMenu : IMenu
    {
        List<MenuItem> menuItems;
        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();
            AddItem("PK1", "PK1_Desc", true, 1.0);
            AddItem("PK2", "PK2_Desc", true, 2.0);
            AddItem("PK3", "PK3_Desc", false, 3.0);
            AddItem("PK4", "PK4_Desc", false, 4.0);
        }

        public object Current => throw new NotImplementedException();

        public void AddItem(string name, string desc, bool veg, double price)
        {
            var menuItem = new MenuItem(name, desc, veg, price);
            menuItems.Add(menuItem);
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return menuItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return menuItems.GetEnumerator();
        }
    }
}
