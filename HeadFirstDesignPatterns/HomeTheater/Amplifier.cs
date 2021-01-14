using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeTheater
{
    class Amplifier
    {
        public Tuner? Tuner { get; set; }
        public CdPlayer? CdPlayer { get; set; }
        public DvdPlayer? DvdPlayer { get; set; }

        public void On() => Console.WriteLine("Amplifier On");
        public void Off() => Console.WriteLine("Amplifier Off");
        public void SetStereoSound() => Console.WriteLine("Amplifier stereo sound");
        public void SetSurroundSound() => Console.WriteLine("Amplifier surround sound");
        public void SetVolume() => Console.WriteLine("Amplifier set volume");
    }
}
