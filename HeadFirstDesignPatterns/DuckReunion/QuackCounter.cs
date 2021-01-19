using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DuckReunion
{
    class QuackCounter : IQuackable
    {
        private IQuackable duck;
        private Observable observable;
        public static int NumberOfQuacks { get; private set; }

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            duck.Quack();
            NumberOfQuacks++;
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public override string? ToString()
        {
            return duck.ToString();
        }
    }
}
