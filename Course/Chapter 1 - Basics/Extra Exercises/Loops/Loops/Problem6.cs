using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Problem6
    {
        //Write a program that calculates n! / k! for given n and k(1 < k<n< 100).
        //Use only one loop.

        //Main method

        //int n = int.Parse(Console.ReadLine());
        //int k = int.Parse(Console.ReadLine());

        //    if (((k > 1) && (k<n)) && ((n > k) && (n< 100)))
        //    {
        //        Problem6 problem6Runner = new Problem6();
        //int problem6Result = problem6Runner.FactorialCalculation2(n, k);
        //Console.WriteLine(problem6Result);
        //    }

        //    else
        //    {
        //        Console.WriteLine("Wrong Input!");
        //    }

public int FactorialCalculation2(int n, int k)
        {
            int factorialN = 1;
            int factorialK = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
                
                if (i <= k)
                {
                    factorialK = factorialK * i;
                }
            }

            int result = factorialN / factorialK;

            return result;

        }
    }
}
