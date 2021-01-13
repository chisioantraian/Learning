using HeadFirstDesignPatterns.HomeAutomation.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Commands
{
    class HottubOffCommand : ICommand
    {
        private Hottub hottub;

        public HottubOffCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute() => hottub.Off();

        public void Undo() => hottub.On();
    }
}
