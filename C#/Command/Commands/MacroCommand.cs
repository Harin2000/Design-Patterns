using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class MacroCommand : ICommand
    {
        ICommand[] commands;
        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }
        public void Execute()
        {
            foreach (ICommand command in commands) { command.Execute(); }
        }

        public void Undo()
        {
            for (int i = commands.Length - 1; i >= 0; i--) { commands[i].Undo(); }
        }
    }
}
