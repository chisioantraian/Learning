using HeadFirstDesignPatterns.SimUDuck.Behaviors.Flying;
using HeadFirstDesignPatterns.SimUDuck.Behaviors.Quacking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck
{
    abstract class Duck
    {
        public IQuackBehavior? QuackBehavior { get; set; }
        public IFlyBehavior? FlyBehavior { get; set; }
        public void PerformQuack() => QuackBehavior?.Quack();
        public void PerformFly() => FlyBehavior?.Fly();
        public void Swim() => Console.WriteLine("Duck Swim");
        public abstract void Display();
    }
}
