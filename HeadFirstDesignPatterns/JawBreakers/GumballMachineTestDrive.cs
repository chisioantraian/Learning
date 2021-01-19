using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.JawBreakers
{
    class GumballMachineTestDrive
    {
        public static void Run()
        {
            Console.Write("Location: ");
            string location = Console.ReadLine() ?? string.Empty;

            Console.Write("Gumballs count: ");
            int count = int.Parse(Console.ReadLine() ?? "0");

            var gumballMachine = new GumballMachine(location, count);
            var monitor = new GumballMonitor(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);

            monitor.Report();
        }
    }
}
