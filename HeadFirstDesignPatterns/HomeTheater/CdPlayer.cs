﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeTheater
{
    class CdPlayer
    {
        private Amplifier amplifier;

        public CdPlayer(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }

        public void On() => Console.WriteLine("CdPlayer On");
        public void Off() => Console.WriteLine("CdPlayer Off");
        public void Eject() => Console.WriteLine("CdPlayer Eject");
        public void Pause() => Console.WriteLine("CdPlayer Pause");
        public void Play() => Console.WriteLine("CdPlayer Play");
        public void Stop() => Console.WriteLine("CdPlayer Stop");
    }
}
