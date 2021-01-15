using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzTemplate
{
    internal static class BeverageSimulator
    {
        public static void Run()
        {
            var teaWithHook = new TeaWithHook();
            var coffeeWithHook = new CoffeeWithHook();

            Console.WriteLine("\nMaking tea...");
            teaWithHook.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeWithHook.PrepareRecipe();
        }
        public static void RunComparable()
        {
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };
            Console.WriteLine("Before sorting: ");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("\nAfter sorting: ");
            Display(ducks);
        }

        private static void Display(Duck[] ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }
    }
}
