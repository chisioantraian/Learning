using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop
{
    abstract class Pizza
    {
        public string? Name { get; protected set; }
        public string? Dough { get; protected set; }
        public string? Sauce { get; protected set; }
        public List<string> Toppings { get; } = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name} pizza");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in Toppings)
            {
                Console.WriteLine($" {topping}");
            }
        }

        public void Bake() => Console.WriteLine("Baking pizza");
        public virtual void Cut() => Console.WriteLine("Cutting pizza");
        public void Box() => Console.WriteLine("Boxing pizza");
    }
}
