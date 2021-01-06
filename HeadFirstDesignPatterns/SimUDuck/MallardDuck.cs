using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck
{
    class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("MallardDuck Display");
        }

        public void Fly()
        {
            Console.WriteLine("MallardDuck Fly");
        }

        public void Quack()
        {
            Console.WriteLine("MallardDuck Quack");
        }
    }
}
