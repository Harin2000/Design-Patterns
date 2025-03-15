using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal abstract class MenuComponent
    {
        public abstract void Add(MenuComponent menuComponent);
        public abstract void Remove(MenuComponent menuComponent);
        public abstract MenuComponent GetChild(int i);
        public abstract string GetName();
        public abstract string GetDescription();
        public abstract bool IsVegetarian();
        public abstract double GetPrice();
        public abstract void Print();
    }
}
