using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StarbuzzTemplate
{
    class Duck : IComparable<Duck>
    {
        public string name;
        public int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public int CompareTo(Duck? other)
        {
            if (this.weight < other?.weight)
            {
                return -1;
            }
            else if (this.weight == other?.weight)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override string? ToString() => $"{name} weighs {weight}";
    }
}
