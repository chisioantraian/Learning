using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
