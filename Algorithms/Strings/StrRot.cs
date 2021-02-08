using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class StrRot
    {
        public static bool IsRotation(string s1, string s2)
        {
            int len = s1.Length;
            if (len == s2.Length && len > 0)
            {
                return IsSubstring(s1 + s1, s2);
            }
            return false;
        }

        private static bool IsSubstring(string s1, string s2)
        {
            return s1.Contains(s2);
        }

        public static void RunAlg()
        {
            string s1 = "waterbottle";
            string s2 = "erbottlewat";
            if (IsRotation(s1, s2))
            {
                Console.WriteLine("Yes " + s1);
            }

            s1 = "tree";
            if (IsRotation(s1, s2))
            {
                Console.WriteLine("Yes " + s1);
            }
            else
            {
                Console.WriteLine("No " + s1);
            }
        }
    }
}
