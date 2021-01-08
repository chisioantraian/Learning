using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzCoffee
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Most excellent Dark Roast";
        }

        public override double Cost => 0.99;
    }
}
