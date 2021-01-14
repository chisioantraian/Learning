using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeTheater
{
    class DvdPlayer
    {
        private Amplifier amplifier;

        public DvdPlayer(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }

        public void On() => Console.WriteLine("DvdPlayer On");
        public void Off() => Console.WriteLine("DvdPlayer Off");
        public void Eject() => Console.WriteLine("DvdPlayer Eject");
        public void Pause() => Console.WriteLine("DvdPlayer Pause");
        public void Play(string movie) => Console.WriteLine($"DvdPlayer Play {movie}");
        public void SetSurroundAudio() => Console.WriteLine("DVD Surround Audio");
        public void SetTwoChannelAudio() => Console.WriteLine("DVD 2-channel Audio");
        public void Stop() => Console.WriteLine("DvdPlayer Stop");
    }
}
