using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    class DNode<T>
    {
        internal T data;
        internal DNode<T>? prev;
        internal DNode<T>? next;
        public DNode(T d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
}
