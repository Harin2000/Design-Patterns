using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Menus
{
    internal class MenuItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Vegetarian { get; private set; }
        public double Price { get; private set; }
        public MenuItem(string name, string desc, bool veg, double price)
        {
            Name = name;
            Description = desc;
            Vegetarian = veg;
            Price = price;
        }
        public override string ToString() {
            return $"{Name}:{Description}:{Vegetarian}:{Price}";
        }
    }
}
