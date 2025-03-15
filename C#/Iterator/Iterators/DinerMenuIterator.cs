﻿using Iterator.Menus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterators
{
    internal class DinerMenuIterator : IEnumerator
    {
        private MenuItem[] menuItems;
        private int position = 0;
        public DinerMenuIterator(MenuItem[] menuItems) {
            this.menuItems = menuItems;
        }

        public object Current => menuItems[position];

        public bool MoveNext()
        {
            if (position < menuItems.Length-1 && menuItems[position+1] != null) { ++position; return true; }
            else return false;
        }

        public void Reset()
        {
            position = 0;
        }
        //public bool HasNext()
        //{
        //    if (position < menuItems.Length && menuItems[position] != null) { return true; }
        //    else return false;
        //}

        //public MenuItem Next()
        //{
        //    return menuItems[position++];
        //}
    }
}
