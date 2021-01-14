using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class Waitress
    {
        private PancakeHouseMenu pancakeHouseMenu;
        private DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = pancakeHouseMenu.CreateIterator();
            var dinerIterator = dinerMenu.CreateIterator();
            Console.WriteLine("Menu\n-----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.WriteLine($"{menuItem.Name} {menuItem.Price} {menuItem.Description}\n");
            }
        }
    }
}
