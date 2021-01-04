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
            
            b.InsertCool(3);
            b.InsertCool(8);
            b.InsertCool(1);
            b.InsertCool(4);
            b.InsertCool(6);
            b.InsertCool(2);
            b.InsertCool(17);
            b.InsertCool(10);
            b.InsertCool(9);
            b.InsertCool(20);
            b.InsertCool(25);
            b.InsertCool(15);
            b.InsertCool(16);

            b.InOrderDisplay();
            Console.WriteLine("\n - - - ");

            if (b.Contains_Rec(10))
            {
                Console.WriteLine(" inside tree");
            }
            else
            {
                Console.WriteLine("NO0 :(");
            }
        }
    }
}
