using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.TurkeyAdapter
{
    internal static class DuckTestDrive
    {
        public static void Run()
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says: ");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe duck says:");
            TestDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says:");
            TestDuck(turkeyAdapter);
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
