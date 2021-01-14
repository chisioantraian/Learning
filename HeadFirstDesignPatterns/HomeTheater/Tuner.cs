using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeTheater
{
    class Tuner
    {
        private Amplifier amplifier;

        public Tuner(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }

        public void On() => Console.WriteLine("Tuner On");
        public void Off() => Console.WriteLine("Tuner Off");
        public void SetAm() => Console.WriteLine("Tuner set AM");
        public void SetFm() => Console.WriteLine("Tuner set FM");
        public void SetFrequency() => Console.WriteLine("Tuner set frequency");
    }
}
