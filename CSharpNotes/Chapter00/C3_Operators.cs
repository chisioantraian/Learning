using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNotes.Chapter00
{
    public struct Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex
            {
                Real = c1.Real + c2.Real,
                Imaginary = c1.Imaginary + c2.Imaginary
            };
        }
    }



    class C3_Operators
    {
        public static void Run()
        {
            Complex a = new Complex() { Real = 1, Imaginary = 2 };
            Complex b = new Complex() { Real = 4, Imaginary = 8 };
            Complex c = a + b;

            Console.WriteLine($"{c.Real}, {c.Imaginary}");
        }
    }
}
