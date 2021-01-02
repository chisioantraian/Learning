using DataStructures.LinkedList;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new SingleLinkedList<int>();

            l.AddAtPosition(0, 67);
            l.AddAtPosition(0, 12);
            l.AddAtPosition(0, 23);
            l.AddAtPosition(1, 59);
            l.AddAtPosition(1, 66);
            l.AddAtPosition(4, 29);
            l.AddAtPosition(6, 88);
            //l.AddAtPosition(8, 16); //error

            foreach (var el in l)
            {
                Console.WriteLine(el);
            }
        }
    }
}
