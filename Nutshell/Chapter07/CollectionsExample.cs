using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutshell.Chapter07
{
    class CollectionsExample
    {
        public static void Run()
        {
            //LinkedListExample();
            ImmutableArrayExample();
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

        private static void ImmutableArrayExample()
        {
            //ImmutableArray<int> array = new ImmutableArray<int> { 1, 2, 3 };
            ImmutableArray<int> array = ImmutableArray.Create<int>(1, 2, 3);
            var list = new[] { 1, 2, 3 }.ToImmutableList();
            var oldList = ImmutableList.Create<int>(1, 2, 3);
            var newList = oldList.Add(44);

            Console.WriteLine(oldList.Count);
            Console.WriteLine(newList.Count);
        }
    }
}
