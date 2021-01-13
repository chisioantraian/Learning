using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation
{
    class SimpleRemoteControl
    {
        public ICommand? Command { private get; set; }

        public SimpleRemoteControl() { }

        public void ButtonWasPressed()
        {
            Command?.Execute();
        }

    }
}
