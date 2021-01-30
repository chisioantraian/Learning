using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nutshell
{
    class TaskTest
    {
        public static void Run()
        {
            CookEggs();
            CookBacon();
        }

        private static async void CookEggs()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Eggs cooked");
            });
        }

        private static async void CookBacon()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Bacon cooked");
            });
        }
    }
}
