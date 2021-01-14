using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeTheater
{
    class TheaterLights
    {
        public void On() => Console.WriteLine("Theater Lights On");
        public void Of() => Console.WriteLine("Theater Lights Off");
        public void Dim() => Console.WriteLine("Theater Lights Dim");
    }
}
