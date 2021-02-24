using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutshell.Chapter04
{
    public struct Note
    {
        int value;
        public Note(int semiTonesFromA) { value = semiTonesFromA; }

        public static Note operator + (Note x, int semitones)
        {
            return new Note(x.value + semitones);
        }
    }
    class OperatorOverloading
    {
        public static void Run()
        {
            Note b = new Note(2);
            Note cs = b + 2;
        }
    }
}
