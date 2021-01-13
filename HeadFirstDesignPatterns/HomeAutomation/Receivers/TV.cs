using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Receivers
{
    class TV
    {
        private string location;

        public TV(string location)
        {
            this.location = location;
        }

        public void On() => Console.WriteLine($"{location} TV is on");
        public void Off() => Console.WriteLine($"{location} TV is off");
    }
}
