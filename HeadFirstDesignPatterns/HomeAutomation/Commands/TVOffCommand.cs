using HeadFirstDesignPatterns.HomeAutomation.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Commands
{
    class TVOffCommand : ICommand
    {
        private TV tv;

        public TVOffCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute() => tv.Off();

        public void Undo() => tv.On();
    }
}
