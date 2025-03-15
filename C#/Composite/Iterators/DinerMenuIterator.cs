using Composite.Menus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Iterators
{
    internal class DinerMenuIterator<MenuItem> : IEnumerator<MenuItem>
    {
        private MenuItem[] menuItems;
        private int position = -1;
        public DinerMenuIterator(MenuItem[] menuItems) {
            this.menuItems = menuItems;
        }

        public object Current => menuItems[position];

        MenuItem IEnumerator<MenuItem>.Current => menuItems[position];

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (position < menuItems.Length-1 && menuItems[position+1] != null) { ++position; return true; }
            else return false;
        }

        public void Reset()
        {
            position = 0;
        }
    }
}
