using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1ProblemsResolved
{
    class Problem2
    {
        public void FibonacciNumbers(int n)
        {
            int firstFib = 0;
            int secondFib = 1;
            int thirdFib = 0;
            Console.WriteLine(firstFib);
            Console.WriteLine(secondFib);

            for (int i = 0; i < n - 2; i++)
            {
                thirdFib = firstFib + secondFib;
                if (thirdFib % 2 == 0)
                {
                    Console.WriteLine(-thirdFib);
                }
                else
                {
                    Console.WriteLine(thirdFib);
                }
                firstFib = secondFib;
                secondFib = thirdFib;
            }
        }

        public void Fibonaci(int n)
        {
            int first = 0;
            int second = 1;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(first);
                Console.WriteLine(second);

                first = first + second;
                second = second + first;
            }
        }

        public void FibonaciDynamic(int n)
        {
            int[] fibArr = new int[n];

            fibArr[0] = 0;
            fibArr[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibArr[i] = fibArr[i - 2] + fibArr[i - 1];
            }

            foreach(var item in fibArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
