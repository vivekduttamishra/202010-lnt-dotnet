using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptArchitect.Utils
{
    public class Primes
    {
        public static bool IsPrime(int value)
        {
            for(var i = 2; i < value; i++)
            {
                if (value % i == 0)
                    return false;
            }

            return true;
        }
    }
}
