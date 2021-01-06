﻿using HeadFirstDesignPatterns.SimUDuck.Behaviors.Flying;
using HeadFirstDesignPatterns.SimUDuck.Behaviors.Quacking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            QuackBehavior = new QuackSound();
            FlyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("Redhead Display");
        }

    }
}
