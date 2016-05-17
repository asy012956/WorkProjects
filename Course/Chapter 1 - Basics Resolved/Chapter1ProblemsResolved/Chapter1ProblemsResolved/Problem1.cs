using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1ProblemsResolved
{
    class Problem1
    {
        public void SumBinaryDigits(int a, int b)
        {
            int sumA = CountBites(a);
            int sumB = CountBites(b);

            Console.WriteLine(sumA + sumB);
        }

        private int CountBites(int a)
        {
            int sum = 0;

            while (a > 0)
            {
                int remainderA = a % 2;
                if (remainderA == 1)
                {
                    sum++;
                }

                a = a >> 1;
            }

            return sum;
        }
    }
}
