using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Receivers
{
    enum FanSpeed
    {
        High,
        Medium,
        Low,
        Off
    }
    class CeilingFan
    {
        private string location;
        public FanSpeed Speed { get; private set; }

        public CeilingFan(string location)
        {
            this.location = location;
            this.Speed = FanSpeed.Off;
        }

        public void High()
        {
            Speed = FanSpeed.High;
            Console.WriteLine($"{location} ceiling fan -> high");
        }
        public void Medium()
        {
            Speed = FanSpeed.Medium;
            Console.WriteLine($"{location} ceiling fan -> medium");
        }
        public void Low()
        {
            Speed = FanSpeed.Low;
            Console.WriteLine($"{location} ceiling fan -> low");
        }

        public void Off()
        {
            Speed = FanSpeed.Off;
            Console.WriteLine($"{location} ceiling fan is off");
        }
    }
}
