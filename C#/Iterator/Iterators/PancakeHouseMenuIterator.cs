using Iterator.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterators
{
    internal class PancakeHouseMenuIterator : IIterator
    {
        List<MenuItem> menuItems;
        int position = 0;
        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }
        public bool HasNext()
        {
            if (position < menuItems.Count) { return true; }
            else return false;
        }

        public MenuItem Next()
        {
            return menuItems[position++];
        }
    }
}
