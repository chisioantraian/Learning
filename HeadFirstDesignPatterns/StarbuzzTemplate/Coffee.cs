using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzTemplate
{
    class Coffee : CaffeineBeverage
    {
        public override void Brew() => Console.WriteLine("Dripping coffee through filter");
        public override void AddCondiments() => Console.WriteLine("Adding sugar and milk");
    }
}
