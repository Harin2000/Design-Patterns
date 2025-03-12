using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Duck
{
    internal interface IDuck
    {
        public void Quack();
        public void Fly();
    }
}
