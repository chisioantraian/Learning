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

namespace HeadFirstDesignPatterns.PizzaShop.Factories
{
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese() => new ReggianoCheese();
        public Clams CreateClam() => new FreshClams();

        public Dough CreateDough() => new ThinCrustDough();

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

        public Sauce CreateSauce() => new MarinaraSauce();

        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie> { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }


    }
}
