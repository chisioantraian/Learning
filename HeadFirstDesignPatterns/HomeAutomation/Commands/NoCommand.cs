using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Commands
{
    class NoCommand : ICommand
    {
        public void Execute() => Console.WriteLine("No command executed");
        public void Undo() => Console.WriteLine("No command undo");
    }
}
