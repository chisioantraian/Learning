using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class Waitress
    {
        private IMenu<MenuItem> pancakeHouseMenu;
        private IMenu<MenuItem> dinerMenu;

        public Waitress(IMenu<MenuItem> pancakeHouseMenu, IMenu<MenuItem> dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var pancakeEnumerator = pancakeHouseMenu.CreateEnumerator();
            var dinerEnumerator = dinerMenu.CreateEnumerator();
            
            Console.WriteLine("Menu\n-----\nBREAKFAST");
            PrintMenu(pancakeEnumerator);
            
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerEnumerator);
        }

        private void PrintMenu(IEnumerator<MenuItem> enumerator)
        {
            while (enumerator.MoveNext())
            {
                MenuItem menuItem = enumerator.Current;
                Console.WriteLine($"{menuItem.Name} {menuItem.Price} {menuItem.Description}\n");
            }
        }
    }
}
