using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class Waitress
    {
        private MenuComponent allMenus;
        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            var enumerator = allMenus.CreateEnumerator();
            Console.WriteLine("\n\nVEGETARIAN MENU\n----");
            while (enumerator.MoveNext())
            {
                var menuComponent = enumerator.Current;
                try
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}
