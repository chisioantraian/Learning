using HeadFirstDesignPatterns.PizzaShop.Ingredients.Cheese;
using HeadFirstDesignPatterns.PizzaShop.Ingredients.Clams;
using HeadFirstDesignPatterns.PizzaShop.Ingredients.Dough;
using HeadFirstDesignPatterns.PizzaShop.Ingredients.Pepperoni;
using HeadFirstDesignPatterns.PizzaShop.Ingredients.Sauce;
using HeadFirstDesignPatterns.PizzaShop.Ingredients.Veggie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace HeadFirstDesignPatterns.PizzaShop
{
    abstract class Pizza
    {
        public string Name { get; set; }
        protected Cheese Cheese;
        protected Clams Clams;
        protected Dough Dough;
        protected Pepperoni Pepperoni;
        protected Sauce Sauce;
        protected List<Veggie> Veggies;

        public abstract void Prepare();

        public void Bake() => Console.WriteLine("Baking pizza");
        public virtual void Cut() => Console.WriteLine("Cutting pizza");
        public void Box() => Console.WriteLine("Boxing pizza");
    }

    enum PizzaType
    {
        Cheese,
        Clam,
        Pepperoni,
        Veggie
    }
}
