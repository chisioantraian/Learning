using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutshell.Chapter07
{
    class CollectionsExample
    {
        public static void Run()
        {
            LinkedListExample();
        }

        private static void LinkedListExample()
        {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                    list.AddFirst(i);
                else
                    list.AddLast(i);
            }

            foreach (int el in list)
            {
                Console.WriteLine(el);
            }
        }
    }
}
