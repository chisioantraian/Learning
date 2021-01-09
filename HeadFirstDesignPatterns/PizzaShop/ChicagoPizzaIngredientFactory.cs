using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop
{
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese() => new Mozzarella();

        public Clams CreateClam() => new FrozenClams();

        public Dough CreateDough() => new ThickCrustDough();

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

        public Sauce CreateSauce() => new PlumTomatoSauce();

        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie> { new Spinach(), new BlackOlives(), new EggPlant() };
        }
    }
}
