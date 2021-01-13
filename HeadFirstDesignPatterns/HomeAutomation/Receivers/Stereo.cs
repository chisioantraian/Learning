using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Receivers
{
    class Stereo
    {
        private string location;

        public Stereo(string location)
        {
            this.location = location;
        }

        public void On() => Console.WriteLine($"{location} Stereo on");
        public void Off() => Console.WriteLine($"{location} Stereo off");
        public void SetCD() => Console.WriteLine($"{location} Stereo setting cd");
        public void SetDVD() => Console.WriteLine($"{location} Stereo setting dvd");
        public void SetRadio() => Console.WriteLine($"{location} Stereo setting radio");
        public void SetVolume(int volume)
        {
            Console.WriteLine($"{location} Stereo volume set to {volume}");
        }
    }
}
