using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzCoffee
{
    class Mocha : CondimentDecorator
    {
        private Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", Mocha";

        public override double Cost => 0.20 + beverage.Cost;
    }
}
