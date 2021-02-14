using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nutshell.Chapter04
{
    class Delegates
    {
        private delegate int Transformer(int x);
        private delegate void ProgressReporter(int percentComplete);
        private delegate T Transformer<T>(T arg);

        class Util
        {
            public static void Transform(int[] values, Transformer t)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = t(values[i]);
            }

            public static void HardWork(ProgressReporter p)
            {
                for (int i = 0; i < 10; i++)
                {
                    p(i * 10);
                    Thread.Sleep(100);
                }
            }

            public static void Trans<T>(T[] values, Transformer<T> t)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = t(values[i]);
            }    
        }

        class X
        {
            public void InstanceProgress(int percentComplete)
                => Console.WriteLine(percentComplete);
        }

        static int Square(int x) => x * x;
        static void WriteProgressToConsole(int percentComplete)
            => Console.WriteLine(percentComplete);
        static void WriteProgressToFile(int percentComplete)
            => File.WriteAllText("progress.txt", percentComplete.ToString());



        public static void Run()
        {
            //SimpleDelegateExample();
            //PluginMethodExample();
            MulticastDelegateExample();
            //InstanceVersusStaticMethodTargetExample();
            //GenericDelegateExample();
        }



        private static void SimpleDelegateExample()
        {
            Transformer t = Square;
            int answer = t(3);
            Console.WriteLine($"answer = {answer}\n");
        }

        private static void PluginMethodExample()
        {
            int[] values = { 1, 2, 3, 6, 5, 4 };
            Util.Transform(values, Square);
            foreach (int i in values)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        private static void MulticastDelegateExample()
        {
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Util.HardWork(p);
            Console.WriteLine(p.Method);
        }

        private static void InstanceVersusStaticMethodTargetExample()
        {
            X x = new X();
            ProgressReporter p = x.InstanceProgress;
            p(99);
            Console.WriteLine(p.Target == x);
            Console.WriteLine(p.Method);
        }

        private static void GenericDelegateExample()
        {
            int[] values = { 2, 4, 6, 8, 7, 5, 3, 1 };
            Util.Trans(values, Square);
            foreach (int i in values)
                Console.Write(i + " ");
        }
    }
}
