using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class DinerMenuEnumerator : IEnumerator<MenuItem>
    {
        private MenuItem[] items;
        private int position = -1;

        public DinerMenuEnumerator(MenuItem[] items)
        {
            this.items = items;
        }

        public MenuItem Current => items[position];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return position < items.Length && items[position] != null;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
