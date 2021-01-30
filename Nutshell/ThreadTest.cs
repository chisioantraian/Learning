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

        private static void WriteY()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("y");
        }
    }
}
