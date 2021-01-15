using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    class CompositeIterator : IEnumerator<MenuComponent>
    {
        private Stack<IEnumerator<MenuComponent>> stack = new();

        public CompositeIterator(IEnumerator<MenuComponent> enumerator)
        {
            stack.Push(enumerator);
            //stack.Push(new NullIterator());
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
                    //stack.Push(component.CreateEnumerator());
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
