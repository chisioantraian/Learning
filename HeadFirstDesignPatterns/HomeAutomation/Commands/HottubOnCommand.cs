using HeadFirstDesignPatterns.HomeAutomation.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Commands
{
    class HottubOnCommand : ICommand
    {
        private Hottub hottub;

        public HottubOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute() => hottub.On();

        public void Undo() => hottub.Off();
    }
}
