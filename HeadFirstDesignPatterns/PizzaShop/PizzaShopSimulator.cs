using HeadFirstDesignPatterns.PizzaShop.Stores.Chicago;
using HeadFirstDesignPatterns.PizzaShop.Stores.NewYork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop
{
    class PizzaShopSimulator
    {
        public static void Run()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza? pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Someone ordered a {pizza?.Name}\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Someone else ordered {pizza?.Name}");
        }
    }
}
