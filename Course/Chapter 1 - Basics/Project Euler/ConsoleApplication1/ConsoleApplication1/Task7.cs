using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Task7
    {
        public void Prime10001st()
        {
            uint counter = 0;
            uint holder = 0;
            for (uint i = 2; i < uint.MaxValue; i++)
            {
                IsPrime(i);
                if (IsPrime(i) == true)
                {
                    holder = i;
                    counter++;
                }

                if (counter == 10001)
                {
                    Console.WriteLine(holder);
                    break;
                }
            }
        }

        public bool IsPrime(uint i)
        {
            bool isPrime = true;
            double limit = Math.Sqrt(i);
            for (uint j = 2; j <= limit; j++)
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
