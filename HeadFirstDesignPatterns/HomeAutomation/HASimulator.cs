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

        public static void RunParty()
        {
            var remote = new RemoteControl();

            var light = new Light("Living Room");
            var tv = new TV("Living Room");
            var stereo = new Stereo("Living Room");
            var hottub = new Hottub();

            var lightOn = new LightOnCommand(light);
            var stereoOn = new StereoOnCommand(stereo);
            var tvOn = new TVOnCommand(tv);
            var hottubOn = new HottubOnCommand(hottub);

            var lightOff = new LightOffCommand(light);
            var stereoOff = new StereoOffCommand(stereo);
            var tvOff = new TVOffCommand(tv);
            var hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
            ICommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

            var partyOnMacro = new MacroCommand(partyOn);
            var partyOffMacro = new MacroCommand(partyOff);

            remote.SetCommand(0, partyOnMacro, partyOffMacro);
            Console.WriteLine(remote);
            Console.WriteLine("--- Pushing Macro On ---");
            remote.OnButtonWasPushed(0);
            Console.WriteLine("--- Pushing Macro Off ---");
            remote.OffButtonWasPushed(0);
        }
    }
}
