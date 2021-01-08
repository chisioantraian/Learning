using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzCoffee
{
    class Soy : CondimentDecorator
    {
        private Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", Soy";

        public override double Cost => 0.15 + beverage.Cost;

        /*public override double Cost => 
            beverage.Cost + this.beverage.Size switch
            {
                BeverageSize.Tall => 0.10,
                BeverageSize.Grande => 0.15,
                BeverageSize.Venti => 0.20
            };*/
    }
}
