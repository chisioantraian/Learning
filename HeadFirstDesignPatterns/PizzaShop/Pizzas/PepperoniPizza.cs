using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop.Pizzas
{
    class PepperoniPizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory, string name)
        {
            this.ingredientFactory = ingredientFactory;
            this.Name = name;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Cheese = ingredientFactory.CreateCheese();
            Clams = ingredientFactory.CreateClam();
            Dough = ingredientFactory.CreateDough();
            Pepperoni = ingredientFactory.CreatePepperoni();
            Sauce = ingredientFactory.CreateSauce();
            Veggies = ingredientFactory.CreateVeggies();
        }
    }
}
