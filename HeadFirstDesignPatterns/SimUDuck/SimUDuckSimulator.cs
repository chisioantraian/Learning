using HeadFirstDesignPatterns.SimUDuck.Behaviors.Flying;
using HeadFirstDesignPatterns.SimUDuck.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck
{
    internal static class SimUDuckSimulator
    {
        public static void Run()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.PerformQuack();
            rubberDuck.Swim();
        }
    }

}
