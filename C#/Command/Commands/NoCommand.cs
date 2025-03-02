using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine($"{GetType()}: {MethodBase.GetCurrentMethod().Name}");
        }

        public void Undo()
        {
            Console.WriteLine($"{GetType()}: {MethodBase.GetCurrentMethod().Name}");
        }
    }
}
