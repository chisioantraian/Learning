using System;
using System.Threading.Tasks;

namespace Nutshell
{
    class Program
    {


        static void Main(string[] args)
        {
            ObjectStack stack = new ObjectStack();
            stack.Push("S");
            string s = (string)stack.Pop();
        }

    }
}
