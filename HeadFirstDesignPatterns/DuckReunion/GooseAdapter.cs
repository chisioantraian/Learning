using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DuckReunion
{
    class GooseAdapter : IQuackable
    {
        private Observable observable;
        private Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            this.observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            goose.Honk();
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public override string? ToString() => "Goose pretending to be a Duck";

    }
}
