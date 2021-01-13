using HeadFirstDesignPatterns.HomeAutomation.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Commands
{
    class TVOnCommand : ICommand
    {
        private TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute() => tv.On();

        public void Undo() => tv.Off();
    }
}
