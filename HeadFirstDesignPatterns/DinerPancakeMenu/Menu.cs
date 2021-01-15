using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class Menu : MenuComponent
    {
        private List<MenuComponent> components = new();
        private string name;
        private string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent menuComponent) => components.Add(menuComponent);

        public override MenuComponent GetChild(int i) => components[i];

        public override string GetDescription() => description;

        public override string GetName() => name;

        public override void Remove(MenuComponent menuComponent) => components.Remove(menuComponent);

        public override void Print()
        {
            Console.Write($"\n\n{name}, {description}\n");
            Console.WriteLine("-------------------");

            foreach (var component in components)
            {
                component.Print();
            }
        }

        public override IEnumerator<MenuComponent> CreateEnumerator()
        {
            return new CompositeIterator(components.GetEnumerator());
        }
    }
}
