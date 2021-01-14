using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class PancakeHouseMenu
    {
        private List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>
            {
                new MenuItem("K&B Pancake Breakfast", "Pancakes with scrambled eggs", true, 2.99),
                new MenuItem("Regular Pancake Breakfast", "Pancakes with fries eggs, sausage", false, 2.99),
                new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49),
                new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59)
            };

        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new PancakeHouseIterator(menuItems);
        }
    }
}
