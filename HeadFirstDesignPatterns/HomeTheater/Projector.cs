using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeTheater
{
    class Projector
    {
        private DvdPlayer dvdPlayer;

        public Projector(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }

        public void On() => Console.WriteLine("Projector On");
        public void Off() => Console.WriteLine("Projector Off");
        public void TvMode() => Console.WriteLine("Projector TvMode");
        public void WideScreenMode() => Console.WriteLine("Projector WideScreenMode");
    }
}
