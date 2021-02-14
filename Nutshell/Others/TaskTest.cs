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
            AnotherMethodHere();
        }

        private static async void AnotherMethodHere()
        {
            var result = await CookEggs();
            CookBacon();
            ToastBread();
        }

        private static async Task<bool> CookEggs()
        {
            bool result = false;
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Eggs cooked");
                result = true;
            });
            return result;
        }

        private static async void CookBacon()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Bacon cooked");
            });
        }

        public static async void ToastBread()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Bread toasted");
            });
        }
    }
}
