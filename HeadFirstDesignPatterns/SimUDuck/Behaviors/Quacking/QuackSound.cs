﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck.Behaviors.Quacking
{
    class QuackSound : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack Quack!:>");
        }
    }
}
