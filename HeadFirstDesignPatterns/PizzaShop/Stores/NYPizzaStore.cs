using HeadFirstDesignPatterns.PizzaShop.Factories;
using HeadFirstDesignPatterns.PizzaShop.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop.Stores
{
    class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            var ingredientFactory = new ChicagoPizzaIngredientFactory();

            return type switch
            {
                PizzaType.Cheese => new CheesePizza(ingredientFactory, "New York Style Cheese Pizza"),
                PizzaType.Clam => new ClamPizza(ingredientFactory, "New York Style Clam Pizza"),
                PizzaType.Pepperoni => new PepperoniPizza(ingredientFactory, "New York Style Pepperoni Pizza"),
                _ => new VeggiePizza(ingredientFactory, "New York Style Veggie Pizza")
            };
        }
    }
}
