using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutshell.Chapter04
{
    class EnumerationAndIterators
    {
        public static void Run()
        {
            //IterateThroughCharacters();
            //CollectionInitializersExample();
            //IteratorExample();
            YieldExample();
        }

        private static void IterateThroughCharacters()
        {
            using (var enumerator = "beer".GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var element = enumerator.Current;
                    Console.WriteLine(element);
                }
            }
        }

        private static void CollectionInitializersExample()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            //...
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
        }

        private static void IteratorExample()
        {
            foreach (int fib in Fibs(12))
            {
                Console.Write(fib + " ");
            }
        }

        private static IEnumerable<int> Fibs(int fibCount)
        {
            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }

        private static void YieldExample()
        {
            foreach (string s in Foo(false))
            {
                Console.WriteLine(s);
            }
        }

        private static IEnumerable<string> Foo(bool breakEarly)
        {
            yield return "One";
            yield return "Two";
            if (breakEarly)
                yield break;
            yield return "Three";


        }
    }
}
