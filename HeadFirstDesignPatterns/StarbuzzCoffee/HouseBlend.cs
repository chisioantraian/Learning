using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzCoffee
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "HouseBlend, delicious beverage";
        }

        public override double Cost => 0.89;
    }
}
