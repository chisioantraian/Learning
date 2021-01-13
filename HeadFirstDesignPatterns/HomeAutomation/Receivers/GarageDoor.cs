using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Receivers
{
    class GarageDoor
    {
        public void Up() => Console.WriteLine("Garage door up");
        public void Down() => Console.WriteLine("Garage door down");
        public void Stop() => Console.WriteLine("Garage door stop");
        public void LightOn() => Console.WriteLine("Garage door light on");
        public void LightOff() => Console.WriteLine("Garage door light off");
    }
}
