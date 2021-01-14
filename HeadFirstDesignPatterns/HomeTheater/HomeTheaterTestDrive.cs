using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeTheater
{
    class HomeTheaterTestDrive
    {
        public static void Run()
        {
            var amplifier = new Amplifier();
            var tuner = new Tuner(amplifier);
            var dvd = new DvdPlayer(amplifier);
            var cd = new CdPlayer(amplifier);
            var projector = new Projector(dvd);
            var screen = new Screen();
            var lights = new TheaterLights();
            var popper = new PopcornPopper();
            var homeTheater = new HomeTheaterFacade(amplifier, tuner, dvd, cd,
                projector, lights, screen, popper);

            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();
            
        }
    }
}
