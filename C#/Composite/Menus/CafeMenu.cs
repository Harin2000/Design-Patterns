using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Menus
{
    internal class CafeMenu:IEnumerable<MenuItem>
    {
        Dictionary<string, MenuItem> menuItems = new Dictionary<string, MenuItem>();
        public CafeMenu()
        {
            AddItem("C1", "C1_Desc", true, 1.0);
            AddItem("C2", "C2_Desc", true, 2.0);
            AddItem("C3", "C3_Desc", false, 3.0);
            AddItem("C4", "C4_Desc", false, 4.0);
        }
        public void AddItem(string name, string desc, bool veg, double price)
        {
            var menuItem = new MenuItem(name, desc, veg, price);
            menuItems.Add(name, menuItem);
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return menuItems.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
