using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck
{
    abstract class Duck
    {
        public void Swim() => Console.WriteLine("Duck Swim");
        public abstract void Display();
    }
}
