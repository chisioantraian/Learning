using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    internal class CompositeIterator : IEnumerator<MenuComponent>
    {
        private readonly Stack<IEnumerator<MenuComponent>> stack = new();

        public CompositeIterator(IEnumerator<MenuComponent> enumerator)
        {
            stack.Push(enumerator);
        }

        public MenuComponent Current
        {
            get
            {
                var enumerator = stack.Peek();
                var component = enumerator.Current;
                if (component is Menu)
                {
                    var en = component.CreateEnumerator();
                    while (en.MoveNext())
                    {
                        stack.Push(en.Current.CreateEnumerator());
                    }
                }
                return component;
            }
        }

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            stack.Pop();
            return stack.Count > 0;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
