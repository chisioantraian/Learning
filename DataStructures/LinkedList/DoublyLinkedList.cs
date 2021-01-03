using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        private DNode<T>? Head;
        private DNode<T>? Tail;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void AddFirst(T d)
        {
            if (Head == null)
            {
                Head = Tail = new DNode<T>(Data: d, Prev: null, Next: null);
            }
            else
            {
                DNode<T> node = new DNode<T>(Data: d, Prev: null, Next: Head);
                Head.Prev = node;
                Head = node;
            }
        }

        public void AddLast(T d)
        {
            if (Tail == null)
            {
                Head = Tail = new DNode<T>(Data: d, Prev: null, Next: null);
            }
            else
            {
                DNode<T> node = new DNode<T>(Data: d, Prev: Tail, Next: null);
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
                var node = new DNode<T>(Data: value, Prev: null, Next: Head);
                if (Head != null)
                    Head.Prev = node;
                Head = node;
                if (Head.Next == null)
                    Tail = Head;
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
                var node = new DNode<T>(Data: value, Prev: h, Next: h.Next);
                if (h.Next == null)
                    Tail = node;
                else
                    h.Next.Prev = node;
                h.Next = node;
            }
            else
            {
                throw new Exception("Position out of range");
            }
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
                    if (Head.Next != null)
                        Head.Next.Prev = null;
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
                    if (Tail.Prev != null)
                        Tail.Prev.Next = null;
                    Tail = Tail.Prev;
                }
            }
        }

        public void RemoveAtPosition(int position)
        {
            if (Head == null)
            {
                return;
            }
            if (position == 0)
            {
                if (Head.Next != null)
                    Head.Next.Prev = null;
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
                return;
            }

            var temp = Head;
            for (int i = 0; i < position-1 && temp != null; i++)
            {
                temp = temp.Next;
            }
            if (temp == null || temp.Next == null)
            {
                return; //or exception?
            }
            var aux = temp.Next.Next;
            if (aux != null)
                aux.Prev = temp;
            temp.Next = aux;
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
