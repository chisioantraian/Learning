using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzTemplate
{
    class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void AddCondiments() => Console.WriteLine("Adding sugar and milk");
        public override void Brew() => Console.WriteLine("Dripping Coffee through filter");

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();
            return answer.StartsWith("y", StringComparison.OrdinalIgnoreCase);
        }

        private string GetUserInput()
        {
            Console.Write("Would you like milk and sugar? (y/n) : ");
            return Console.ReadLine() ?? "no";
        }
    }
}
