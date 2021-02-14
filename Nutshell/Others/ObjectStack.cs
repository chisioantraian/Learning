using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutshell
{
    class P
    {
        P(int a, int b) { }
    }
    class ObjectStack<T> where T : new()
    {
        private int position;
        object[] data = new object[10];
        public void Push(object obj) => data[position++] = obj;
        public object Pop() => data[--position];
    }
}
