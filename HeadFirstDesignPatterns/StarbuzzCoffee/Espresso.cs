using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzCoffee
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "The best Espresso";
        }

        public override double Cost => 1.99;
    }
}
