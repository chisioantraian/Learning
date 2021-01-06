using HeadFirstDesignPatterns.SimUDuck.Behaviors.Flying;
using HeadFirstDesignPatterns.SimUDuck.Behaviors.Quacking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("RubberDuck Display");
        }
    }
}
