using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DuckReunion
{
    class RedheadDuck : IQuackable
    {
        private Observable observable;
        public RedheadDuck()
        {
            this.observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack() => Console.WriteLine("Redhead quack");

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public override string? ToString() => "Redhead duck";

    }
}
