using Iterator.Menus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterators
{
    internal class PancakeHouseMenuIterator : IEnumerator
    {
        List<MenuItem> menuItems;
        int position = 0;
        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        public object Current => menuItems[position];

        //public bool HasNext()
        //{
        //    if (position < menuItems.Count) { return true; }
        //    else return false;
        //}

        public bool MoveNext()
        {
            if (position < menuItems.Count-1) { 
                ++position;
                return true; 
            }
            else return false;
        }

        //public MenuItem Next()
        //{
        //    return menuItems[position++];
        //}

        public void Reset()
        {
            position = 0;
        }
    }
}
