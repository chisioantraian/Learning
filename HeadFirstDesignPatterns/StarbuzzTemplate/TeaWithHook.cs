using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzTemplate
{
    class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void AddCondiments() => Console.WriteLine("Adding lemon");

        public override void Brew() => Console.WriteLine("Steeping the tea");
    }
}
