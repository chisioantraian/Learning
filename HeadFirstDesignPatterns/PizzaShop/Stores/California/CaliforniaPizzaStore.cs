using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop.Stores.California
{
    class CaliforniaPizzaStore : PizzaStore
    {
        public override Pizza? CreatePizza(string type)
        {
            Pizza? pizza = null;
            if (type == "cheese")
            {
                pizza = new CaliforniaStyleCheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new CaliforniaStylePepperoniPizza();
            }
            else if (type == "clam")
            {
                pizza = new CaliforniaStyleClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new CaliforniaStyleVeggiePizza();
            }
            return pizza;
        }
    }
}
