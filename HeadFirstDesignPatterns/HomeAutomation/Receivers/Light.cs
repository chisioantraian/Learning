using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Receivers
{
    class Light
    {
        private string location;

        public Light(string location)
        {
            this.location = location;
        }

        public void On() => Console.WriteLine($"{location} light is on");
        public void Off() => Console.WriteLine($"{location} light is off");
    }
}
