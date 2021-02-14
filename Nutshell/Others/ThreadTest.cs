using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nutshell
{
    class ThreadTest
    {
        public static void Run()
        {
            Thread t = new Thread(WriteY);
            t.Start();

            for (int i = 0; i < 1000; i++)
                Console.Write("x");
        }

        public static void Run2()
        {
            Thread t = new Thread(Go);
            t.Start();
            t.Join();
            Console.WriteLine("Thread t has ended");
        }

        public static void Run3()
        {
            Thread t = new Thread(() => Console.WriteLine("hello from thread t"));
            t.Start();
        }

        public static void Run4()
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(() => Console.Write(i)).Start();
            }
        }

        public static void Run5()
        {
            for (int i = 0; i < 10; i++)
            {
                int temp = i;
                new Thread(() => Console.Write(temp)).Start();
            }
        }

        public static void Run6()
        {
            string text = "t1";
            Thread t1 = new Thread(() => Console.Write(text));

            text = "t2";
            Thread t2 = new Thread(() => Console.Write(text));

            t1.Start();
            t2.Start();
        }

        public static void Run7()
        {
            new Thread(GoNull).Start();
        }

        private static void GoNull()
        {
            throw null;
        }

        private static void WriteY()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("y");
        }

        private static void Go()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("y");
        }
    }
}
