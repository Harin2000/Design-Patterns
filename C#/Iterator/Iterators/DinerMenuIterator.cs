using Iterator.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterators
{
    internal class DinerMenuIterator : IIterator
    {
        private MenuItem[] menuItems;
        private int position = 0;
        public DinerMenuIterator(MenuItem[] menuItems) {
            this.menuItems = menuItems;
        }
        public bool HasNext()
        {
            if (position < menuItems.Length && menuItems[position] != null) { return true; }
            else return false;
        }

        public MenuItem Next()
        {
            return menuItems[position++];
        }
    }
}
