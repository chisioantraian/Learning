using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DuckReunion
{
    class Flock : IQuackable
    {
        private List<IQuackable> quackers = new();

        public void Add(IQuackable quacker)
        {
            quackers.Add(quacker);
        }

        public void NotifyObservers()
        {
            foreach (var quacker in quackers)
            {
                quacker.NotifyObservers();
            }
        }

        public void Quack()
        {
            foreach (var quacker in quackers)
            {
                quacker.Quack();
            }
            //NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (var quacker in quackers)
            {
                quacker.RegisterObserver(observer);
            }
        }
    }
}
