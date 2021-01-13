using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Receivers
{
    class Hottub
    {
        public void On() => Console.WriteLine("Hottub is heating");
        public void Off() => Console.WriteLine("Hottub is cooling");
    }
}
