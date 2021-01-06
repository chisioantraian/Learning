using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck
{
    class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Redhead Display");
        }

        public void Fly()
        {
            Console.WriteLine("Redhead Fly");
        }

        public void Quack()
        {
            Console.WriteLine("Redhead Quack");
        }
    }
}
