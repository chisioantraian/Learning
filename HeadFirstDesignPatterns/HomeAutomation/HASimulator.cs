using HeadFirstDesignPatterns.HomeAutomation.Commands;
using HeadFirstDesignPatterns.HomeAutomation.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation
{
    class HASimulator
    {
        public static void Run()
        {
            var remote = new RemoteControl();

            var ceilingFan = new CeilingFan("Living Room");

            var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remote.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            remote.SetCommand(1, ceilingFanHigh, ceilingFanOff);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();
            
            remote.OnButtonWasPushed(1);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();
        }
    }
}
