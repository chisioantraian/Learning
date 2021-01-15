using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class MenuItem : MenuComponent
    {
        public string Name { get; }
        public string Description { get; }
        public bool Vegetarian { get; }
        public double Price { get; } 

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Vegetarian = vegetarian;
            this.Price = price;
        }

        public override string GetName() => Name;
        public override string GetDescription() => Description;
        public override double GetPrice() => Price;
        public override bool IsVegetarian() => Vegetarian;

        public override void Print()
        {
            Console.Write($"{Name}");
            if (Vegetarian)
            {
                Console.Write("(v)");
            }
            Console.WriteLine($", {Price}");
            Console.WriteLine($" -- {Description}");
        }

        public override IEnumerator<MenuComponent> CreateEnumerator()
        {
            return new NullIterator();
        }
    }
}
