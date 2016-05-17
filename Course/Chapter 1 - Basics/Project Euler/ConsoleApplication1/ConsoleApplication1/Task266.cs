using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    //The divisors of 12 are: 1,2,3,4,6 and 12.
    //The largest divisor of 12 that does not exceed the square root of 12 is 3.
    //We shall call the largest divisor of an integer n that does not exceed the square root of n the pseudo square root(PSR) of n.
    //It can be seen that PSR(3102)=47.

    //Let p be the product of the primes below 190.
    //Find PSR(p) mod 1016.

    public class Task266
    {
        public void TaskSolution()
        {
            uint[] primes = PrimesUntil(190);

            ulong product = 1;
            for (int i = 0; i < primes.Length; i++)
            {
                checked
                {
                    product *= primes[i];
                }
            }

            ulong result = PSR(product);
            Console.WriteLine(result);
        }

        public uint[] PrimesUntil(uint number)
        {
            List<uint> list = new List<uint>();

            for(uint i = 1; i < number; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }

            return list.ToArray();
        }

        public bool IsPrime(ulong i)
        {
            bool isPrime = true;
            double limit = Math.Sqrt(i);
            for (ulong j = 2; j <= limit; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }

        public ulong PSR(ulong number)
        {
            ulong result = 0;
            for (ulong i = (ulong)Math.Abs(Math.Sqrt(number)); i >= 1; i--)
            {
                if (number % i == 0)
                {
                    result = i;
                }
            }

            return result;
        }
    }
}
