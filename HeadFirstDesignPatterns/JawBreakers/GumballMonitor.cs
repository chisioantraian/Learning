using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.JawBreakers
{
    class GumballMonitor
    {
        private GumballMachine machine;

        public GumballMonitor(GumballMachine gumballMachine)
        {
            this.machine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine($"Gumball Machine: {machine.Location}");
            Console.WriteLine($"Current Inventory: {machine.Count} gumballs");
            Console.WriteLine($"Current State: {machine.CurrentState}");
        }
    }
}
