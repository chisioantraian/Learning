using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    class Node<T>
    {
        internal T Data;
        internal Node<T>? Next;
        public Node(T Data, Node<T>? Next)
        {
            this.Data = Data;
            this.Next = Next;
        }
    }
}
