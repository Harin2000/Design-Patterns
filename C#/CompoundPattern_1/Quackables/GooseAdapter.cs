using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern_1.Quackables
{
    internal class GooseAdapter : IQuackable
    {
        Goose goose;
        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }
        public void Quack()
        {
            goose.Honk();
        }
    }
}
