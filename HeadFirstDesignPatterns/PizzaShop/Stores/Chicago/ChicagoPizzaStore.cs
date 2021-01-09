using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.PizzaShop.Stores.Chicago
{
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza? CreatePizza(string type)
        {
            Pizza? pizza = null;
            if (type == "cheese")
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            else if (type == "clam")
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new ChicagoStyleVeggiePizza();
            }
            return pizza;
        }
    }
}
