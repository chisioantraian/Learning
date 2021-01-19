using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DuckReunion
{
    class DuckSimulator
    {
        public static void Run()
        {
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            Simulate(duckFactory);
        }

        private static void Simulate(AbstractDuckFactory duckFactory)
        {
            var redheadDuck = duckFactory.CreateRedheadDuck();
            var duckCall = duckFactory.CreateDuckCall();
            var rubberDuck = duckFactory.CreateRubberDuck();
            var gooseDuck = new GooseAdapter(new Goose());
            Console.WriteLine("\nDuck simulator: With Composite - Flocks");

            var flockOfDucks = new Flock();
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            var mallardOne = duckFactory.CreateMallardDuck();
            var mallardTwo = duckFactory.CreateMallardDuck();
            var mallardThree = duckFactory.CreateMallardDuck();
            var mallardFour = duckFactory.CreateMallardDuck();
            var flockOfMallards = new Flock();
            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);
            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\n Duck simulator: With observer");
            var quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);
            
            Simulate(flockOfDucks);

            Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
