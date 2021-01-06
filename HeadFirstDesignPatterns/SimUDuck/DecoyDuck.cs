using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck
{
    class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("DecoyDuck Display");
        }
    }
}
