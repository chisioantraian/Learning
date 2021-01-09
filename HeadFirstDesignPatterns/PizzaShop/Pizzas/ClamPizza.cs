﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop.Pizzas
{
    class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory, string name)
        {
            this.ingredientFactory = ingredientFactory;
            this.Name = name;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Clams = ingredientFactory.CreateClam();
        }
    }
}
