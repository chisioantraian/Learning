using HeadFirstDesignPatterns.SimUDuck.Behaviors.Flying;
using HeadFirstDesignPatterns.SimUDuck.Behaviors.Quacking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck.Ducks
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new QuackSound();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
