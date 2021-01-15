using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class NullIterator : IEnumerator<MenuComponent>
    {
        public MenuComponent Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
