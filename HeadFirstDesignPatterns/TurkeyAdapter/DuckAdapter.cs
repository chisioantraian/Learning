using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.TurkeyAdapter
{
    class DuckAdapter : ITurkey
    {
        private IDuck duck;

        public DuckAdapter(IDuck duck)
        {
            this.duck = duck;
        }

        public void Gobble()
        {
            duck.Quack();
        }

        public void Fly()
        {
            duck.Fly();
        }

    }
}
