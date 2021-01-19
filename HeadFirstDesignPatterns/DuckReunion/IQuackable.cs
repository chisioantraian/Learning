using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DuckReunion
{
    interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}
