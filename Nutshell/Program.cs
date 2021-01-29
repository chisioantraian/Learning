using System;

namespace Nutshell
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(3, 4);
            var (width, height) = rect;
            Console.WriteLine($"{width} {height}");
        }

    }
}
