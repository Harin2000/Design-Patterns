using Iterator.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterators
{
    internal interface IIterator
    {
        bool HasNext();
        MenuItem Next(); 
    }
}
