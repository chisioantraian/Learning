using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nutshell
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await AsyncBreakfast.Run5();
            Console.Read();
        }
    }
}
