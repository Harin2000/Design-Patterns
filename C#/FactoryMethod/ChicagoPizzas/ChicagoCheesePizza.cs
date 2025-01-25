using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryFranchised.Pizzas
{
    internal class ChicagoCheesePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine($"Baking {this.GetType()}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {this.GetType()}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {this.GetType()}");
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {this.GetType()}");
        }
    }
}
