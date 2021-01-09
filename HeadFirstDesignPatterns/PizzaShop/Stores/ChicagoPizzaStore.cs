using HeadFirstDesignPatterns.PizzaShop.Factories;
using HeadFirstDesignPatterns.PizzaShop.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop.Stores
{
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            var ingredientFactory = new ChicagoPizzaIngredientFactory();

            return type switch
            {
                PizzaType.Cheese    => new CheesePizza(ingredientFactory, "Chicago Style Cheese Pizza"),
                PizzaType.Clam      => new ClamPizza(ingredientFactory, "Chicago Style Clam Pizza"),
                PizzaType.Pepperoni => new PepperoniPizza(ingredientFactory, "Chicago Style Pepperoni Pizza"),
                _                   => new VeggiePizza(ingredientFactory, "Chicago Style Veggie Pizza")
            };
        }
    }
}
