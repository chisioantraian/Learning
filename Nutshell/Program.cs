using System;

namespace Nutshell
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Sentence();
            Console.WriteLine(s[3]);
            s[3] = "Kangaroo";
            Console.WriteLine(s[3]);
        }

    }
}
