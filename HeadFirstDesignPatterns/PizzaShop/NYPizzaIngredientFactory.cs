using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop
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
            return new List<Veggie> { new Garlic(), new Onion(), new Mushrom(), new RedPepper() };
        }
    }
}
