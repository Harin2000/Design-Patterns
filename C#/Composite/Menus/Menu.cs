using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Menus
{
    internal class Menu : MenuComponent
    {
        string description;
        string name;
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }
        public override MenuComponent GetChild(int i)
        {
            return menuComponents[i];
        }
        public override string GetDescription()
        {
            return description;
        }
        public override string GetName()
        {
            return name;
        }
        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override double GetPrice()
        {
            throw new NotImplementedException();
        }

        public override bool IsVegetarian()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            //TODO: Fix this
            Console.WriteLine($"Menu:{name}:{description}\n");
            foreach (MenuComponent menuComponent in menuComponents) {
                menuComponent.Print();
            }
        }
    }
}
