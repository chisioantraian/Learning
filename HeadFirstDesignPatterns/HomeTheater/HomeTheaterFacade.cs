using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeTheater
{
    class HomeTheaterFacade
    {
        private Amplifier amplifier;
        private Tuner tuner;
        private DvdPlayer dvd;
        private CdPlayer cd;
        private Projector projector;
        private TheaterLights lights;
        private Screen screen;
        private PopcornPopper popper;
public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, DvdPlayer dvd, CdPlayer cd, Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            this.amplifier = amplifier;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.lights = lights;
            this.screen = screen;
            this.popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Facade Watch Movie");
            popper.On();
            popper.Pop();
            lights.Dim();
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amplifier.On();
            amplifier.DvdPlayer = dvd;
            amplifier.SetSurroundSound();
            amplifier.SetVolume();
            dvd.On();
            dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Facade End Movie");
            popper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amplifier.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();
        }

        public void ListenToCd() => Console.WriteLine("Facade Listen to CD");
        public void EndCD() => Console.WriteLine("Facade End CD");
        public void ListenRadio() => Console.WriteLine("Facade Listen Radio");
        public void EndRadio() => Console.WriteLine("Facade End Radio");
    }
}
