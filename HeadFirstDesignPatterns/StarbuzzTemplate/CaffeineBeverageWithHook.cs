using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzTemplate
{
    abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();
        public abstract void AddCondiments();
        public void BoilWater() => Console.WriteLine("Boiling water");
        public void PourInCup() => Console.WriteLine("Pouring into cup");
        public virtual bool CustomerWantsCondiments() => true;
    }
}
