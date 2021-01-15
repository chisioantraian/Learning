using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    internal static class MenuSimulator
    {
        public static void Run()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();
        }
    }
}
