using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsGraduation
{
    public class PrimeSeeker
    {
        public bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            if (number < 4)
            {
               return true;
            }

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

        /// <summary>
        /// Returns all the prime numbers in the interval 1 to n (including)
        /// </summary>
        /// <param name="n">The end of the interval</param>
        public int[] PrimesTill(int n)
        {
            List<int> primeNumbers = new List<int>();

            for (int i = 2; i < n; i++)
            {
                bool isPrime = IsPrime(i);
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
            }

            return primeNumbers.ToArray();
        }

    }
}
