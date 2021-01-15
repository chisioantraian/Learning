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
            var pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            var dinerMenu = new Menu("DINER MENU", "Lunch");
            var cafeMenu = new Menu("CAFE MENU", "Dinner");
            var dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            var allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            pancakeHouseMenu.Add(new MenuItem("K&B Pancake Breakfast", "Pancakes with scrambled eggs", true, 2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fries eggs, sausage", false, 2.99));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            pancakeHouseMenu.Add(new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59));

            cafeMenu.Add(new MenuItem("Veggie Burger", "Veggie Burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99));
            cafeMenu.Add(new MenuItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69));
            cafeMenu.Add(new MenuItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29));

            dinerMenu.Add(new MenuItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99));
            dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat, si cu salam", false, 2.99));
            dinerMenu.Add(new MenuItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29));
            dinerMenu.Add(new MenuItem("Hotdog", "A hotdog, with saurkraut, relish, onions, topped with cheese", false, 3.05));
            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, adn a slice of sourdough bread", true, 3.89));

            dinerMenu.Add(dessertMenu);
            dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with a flakey crust, topped with vanilla icecream", true, 1.59));

            var waitress = new Waitress(allMenus);
            //waitress.PrintMenu();
            waitress.PrintVegetarianMenu(); //return later
        }
    }
}
