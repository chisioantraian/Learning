using DataStructures.LinkedList;
using DataStructures.Tree;
using System;

namespace DataStructures
{
    class Program
    {
        public static void Main()
        {
            var b = new BinarySearchTree();
            b.Insert(3);
            b.Insert(8);
            b.Insert(1);
            b.Insert(4);
            b.Insert(6);
            b.Insert(2);
            
            b.Insert(10);
            b.Insert(9);
            b.Insert(20);
            b.Insert(25);
            b.Insert(15);
            b.Insert(16);

            b.InOrderDisplay();

        }
    }
}
