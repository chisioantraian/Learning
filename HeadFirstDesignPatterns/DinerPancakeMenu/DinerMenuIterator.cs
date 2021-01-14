using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class DinerMenuIterator : IIterator<MenuItem>
    {
        private MenuItem[] items;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position < items.Length && items[position] != null;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }
    }
}
