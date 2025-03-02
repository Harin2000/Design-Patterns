using Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    enum OnOff
    {
        On,
        Off
    }
    internal class RemoteControl
    {
        public ICommand[] onCommands { get; set; }
        public ICommand[] offCommands { get; set; }
        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            for (int i = 0; i < 7; i++) {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
        }
        ICommand lastCommand = new NoCommand();
        public void OnPushed(int slot)
        {
            onCommands[slot].Execute();
            lastCommand = onCommands[slot];
        }
        public void OffPushed(int slot)
        {
            offCommands[slot].Execute();
            lastCommand = offCommands[slot];
        }
        public void Undo()
        {
            Console.Write("Attempting Undo: ");
            lastCommand.Undo();
        }
        public override string ToString()
        {
            string answer = "";
            for (int i = 0; i < 7; i++)
            {
                answer += $"At slot:{i}, On command: {onCommands[i]}, Off command: {offCommands[i]}\n";
            }
            return answer;
        }
    }
}
