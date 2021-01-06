using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck
{
    class SimUDuckSimulator
    {
        public static void Run()
        {
            Duck mallard = new MallardDuck();
            Duck redhead = new RedheadDuck();

            mallard.Display();
            redhead.Display();
            redhead.Swim();
        }
    }
}
