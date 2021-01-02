using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    class SingleLinkedList<T> : IEnumerable<T>
    {
        internal Node<T>? Head;
        internal Node<T>? Tail;

        public SingleLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void AddFirst(T d)
        {
            if (Head == null)
            {
                Head = Tail = new Node<T> { Data = d, Next = null };
            }
            else
            {
                Node<T> node = new Node<T> { Data = d, Next = Head };
                Head = node;
            }
        }

        public void AddLast(T d)
        {
            if (Tail == null)
            {
                Head = Tail = new Node<T> { Data = d, Next = null };
            }
            else
            {
                Node<T> node = new Node<T> { Data = d, Next = null };
                Tail.Next = node;
                Tail = node;
            }
        }

        public void AddAtPosition(int position, T value)
        {
            if (position < 0)
            {
                throw new Exception("Invalid position");
            }
            if (position == 0)
            {
                var node = new Node<T> { Data = value, Next = Head };
                Head = node;
                return;
            }

            var h = Head;
            while ((position > 1) && (h != null))
            {
                h = h.Next;
                position--;
            }
            if ((position == 1) && (h != null))
            {
                var node = new Node<T> { Data = value, Next = h.Next };
                h.Next = node;
            }
            else
            {
                throw new Exception("Position out of range");
            }

            /*var aux = new Node<T> { Next = Head };
            var HeadCopy = aux;
            while ((position > 0) && (aux != null))
            {
                aux = aux.Next;
                position--;
            }
            if ((position == 0) && (aux != null))
            {
                var nod = new Node<T> { Data = value, Next = aux.Next };
                aux.Next = nod;
                Head = HeadCopy.Next;
            }
            else
            {
                throw new Exception("Invalid position");
            }*/
        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                if (Head == Tail)
                {
                    Head = Tail = null;
                }
                else
                {
                    Head = Head.Next;
                }
            }
        }

        public void RemoveLast()
        {
            if (Tail != null)
            {
                if (Head == Tail)
                {
                    Head = Tail = null;
                }
                else
                {
                    var node = Head;
                    while (node?.Next != Tail)
                    {
                        node = node?.Next;
                    }
                    node.Next = null;
                    Tail = node;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = Head;
            while (node != null)
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
