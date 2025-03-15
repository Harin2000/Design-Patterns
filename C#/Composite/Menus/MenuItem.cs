using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Menus
{
    internal class MenuItem:MenuComponent
    {
        string name;
        string desc;
        bool veg;
        double price;
        public MenuItem(string name, string desc, bool veg, double price)
        {
            this.name = name;
            this.desc = desc;
            this.veg = veg;
            this.price = price;
        }
        public override string ToString() {
            return $"{GetName()}:{GetDescription()}:{IsVegetarian()}:{GetPrice()}";
        }
        public override void Print()
        {
            Console.WriteLine(ToString());
        }
        public override void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return desc;
        }

        public override bool IsVegetarian()
        {
            return veg;
        }

        public override double GetPrice()
        {
            return price;
        }
    }
}
