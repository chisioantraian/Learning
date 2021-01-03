using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    class DNode<T>
    {
        internal T Data;
        internal DNode<T>? Prev;
        internal DNode<T>? Next;

        public DNode(T Data, DNode<T>? Prev, DNode<T>? Next)
        {
            this.Data = Data;
            this.Prev = Prev;
            this.Next = Next;
        }
    }
}
