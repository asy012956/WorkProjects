using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Problem5
    {
        //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
        //Use only one loop. Print the result with 5 digits after the decimal point.

        //Main method

        //int n = int.Parse(Console.ReadLine());
        //int x = int.Parse(Console.ReadLine());
        //Problem5 problem5Runner = new Problem5();
        //double problem5Result = problem5Runner.FactorialCalculation(n, x);
        //Console.WriteLine("{0:F5}", problem5Result);

        public double FactorialCalculation(int n, int x)
        {
            double sum = 1;
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
                sum = sum + (factorial / Math.Pow(x, i));
            }

            return sum;
        }
    }
}
