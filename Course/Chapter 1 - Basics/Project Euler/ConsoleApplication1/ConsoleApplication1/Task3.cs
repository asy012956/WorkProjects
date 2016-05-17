using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Task3
    {
        public void LargestPrimeFactor()
        {
            long number = 600851475143;
            long largestPrimeFactor = 0;
            for (long i = 1000; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    bool iIsPrimeNumber = IsPrime(i);
                    if (iIsPrimeNumber)
                    {
                        largestPrimeFactor = i;
                    }
                }
            }

            Console.WriteLine(largestPrimeFactor);
        }

        public bool IsPrime(long i)
        {
            bool isPrime = true;
            double limit = Math.Sqrt(i);
            for (long j = 2; j <= limit; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
