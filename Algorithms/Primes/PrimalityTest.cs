using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Primes
{
    class PrimalityTest
    {
        public static bool IsPrime(int num)
        {
            if (num == 2 || num == 3)
                return true;
            if (num % 2 == 0 || num % 3 == 0 || num < 5)
                return false;
            int sq = (int)Math.Sqrt(num);
            for (int div = 5; div <= sq; div += 6)
            {
                if (num % div == 0 || num % (div + 2) == 0)
                    return false;
            }
            return true;
        }

        public static void RunAlg()
        {
            for (int num = 1; num <= 100; num++)
            {
                if (IsPrime(num))
                    Console.WriteLine(num);
            }
        }
    }
}
