using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop
{
    interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public List<Veggie> CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClam();
    }
}
