using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzCoffee
{
    class Whip : CondimentDecorator
    {
        private Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", Whip";

        public override double Cost => 0.10 + beverage.Cost;
    }
}
