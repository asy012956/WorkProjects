using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Loops
{
    public class Problem18
    {
        public BigInteger TrailingZeroes(BigInteger n)
        {
            //Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
            //Your program should work well for very big numbers, e.g.n = 100000.

            //Main method
            //BigInteger n = BigInteger.Parse(Console.ReadLine());
            //Problem18 problem18Runner = new Problem18();
            //BigInteger problem18Result = problem18Runner.TrailingZeroes(n);
            //Console.WriteLine(problem18Result);

            BigInteger factorial = 1;
            while (n != 0)
            {
                factorial = factorial * n;
                n--;
            }

            BigInteger numberOfZeroes = 0;
            string stringFactorial = Convert.ToString(factorial);
            char[] stringArray = stringFactorial.ToCharArray();
            Array.Reverse(stringArray);
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] == '0')
                {
                    numberOfZeroes++;
                }
                               
                else
                {
                    break;
                }
            }

            return numberOfZeroes;
        }
    }
}
