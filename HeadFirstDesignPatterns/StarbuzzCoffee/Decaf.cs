using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzCoffee
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decafeinated coffee";
        }

        public override double Cost => 1.05;
    }
}
