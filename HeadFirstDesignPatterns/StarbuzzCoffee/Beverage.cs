using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzCoffee
{
    enum BeverageSize
    {
        Tall,
        Grande,
        Venti
    }

    abstract class Beverage
    {
        public virtual string Description { get; protected set; } = "Unknown Beverage";

        public abstract double Cost { get; }

        public BeverageSize Size { get; set; } //?
    }
}
