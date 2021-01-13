using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.TurkeyAdapter
{
    class MallardDuck : IDuck
    {
        public void Fly() => Console.WriteLine("I'm flying");

        public void Quack() => Console.WriteLine("Quacking");
    }
}
