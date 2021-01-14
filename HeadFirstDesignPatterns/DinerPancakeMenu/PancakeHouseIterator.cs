using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class PancakeHouseIterator : IIterator<MenuItem>
    {
        private List<MenuItem> items;
        private int position = 0;

        public PancakeHouseIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position < items.Count;
        }

        public MenuItem Next()
        {
            return items[position++];
        }
    }
}
