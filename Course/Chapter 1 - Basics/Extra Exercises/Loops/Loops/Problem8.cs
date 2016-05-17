using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Loops
{
    public class Problem8
    {
        public BigInteger CatalanNumbers(int n)
        {

            //In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
            //Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

            //Top part
            int top = 2 * n;
            BigInteger factorialTop = 1;

            for (int i = 1; i <= top; i++)
            {
                factorialTop = factorialTop * i;
            }

            //Bottom part 1
            int bottom1 = n + 1;
            BigInteger bottom1Factorial = 1;
            for (int i = 1; i <= bottom1; i++)
            {
                bottom1Factorial = bottom1Factorial * i;
            }

            //Bottom part 2
            BigInteger bottom2Factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                bottom2Factorial = bottom2Factorial * i;
            }

            //Bottom 

            BigInteger bottom = bottom1Factorial * bottom2Factorial;

            BigInteger result = factorialTop / bottom;

            return result;
        }
    }
}
