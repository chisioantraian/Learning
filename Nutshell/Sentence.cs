using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutshell
{
    class Sentence
    {
        private string[] words = "The quick brown fox".Split();

        public string this[int pos]
        {
            get => words[pos];
            set => words[pos] = value;
        }
    }
}
