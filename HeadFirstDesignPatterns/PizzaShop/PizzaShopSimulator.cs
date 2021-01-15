using HeadFirstDesignPatterns.PizzaShop.Stores;
using System;


namespace HeadFirstDesignPatterns.PizzaShop
{
    internal static class PizzaShopSimulator
    {
        public static void Run()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Someone ordered a {pizza?.Name}\n");

            pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Someone else ordered {pizza?.Name}");
        }
    }
}
