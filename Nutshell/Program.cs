using Nutshell.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nutshell
{
    class Program
    {
        static int Factorial(int x)
        {
            int Fact(int x, int accumulator) => x switch
            {
                <= 1 => accumulator,
                _ => Fact(x - 1, x * accumulator)
            };
            
            return Fact(x, 1);
        }
        static void Main(string[] args)
        {
            WriteLine($"Factorial of 2 : {Factorial(2)}");
            WriteLine($"Factorial of 7 : {Factorial(7)}");
        }
    }
}
