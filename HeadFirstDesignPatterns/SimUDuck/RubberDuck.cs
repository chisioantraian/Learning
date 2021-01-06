using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck
{
    class RubberDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("RubberDuck Display");
        }

        public void Quack()
        {
            Console.WriteLine("RubberDuck Quack");
        }
    }
}
