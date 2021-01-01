using DataStructures.LinkedList;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new SingleLinkedList<int>();
            
            for (int i = 1; i <= 9; i++)
            {
                l.AddLast(i * i);
            }

            l.RemoveFirst();
            l.RemoveFirst();

            l.RemoveLast();
            

            /*var en = l.GetEnumerator();
            while (en.MoveNext())
            {
                int el = en.Current;
                Console.WriteLine(el);
            }*/

            foreach (var el in l)
            {
                Console.WriteLine(el);
            }
        }
    }
}
