using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Loops
{
    public class Problem7
    {
        //In combinatorics, the number of ways to choose k different members out of a group of n different elements 
        //(also known as the number of combinations) is calculated by the following formula: 
        //formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
        //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k(1 < k<n< 100). Try to use only two loops.

        // Main method
        //int n = int.Parse(Console.ReadLine());
        //int k = int.Parse(Console.ReadLine());

        //    if (((k > 1) && (k<n)) && ((n > k) && (n< 100)))
        //    {
        //        Problem7 problem7Runner = new Problem7();
        //BigInteger problem7Result = problem7Runner.Factorial3(n, k);
        //Console.WriteLine(problem7Result);
        //    }

        //    else
        //    {
        //        Console.WriteLine("Wrong Input!");
        //    }

public BigInteger Factorial3(int n, int k)
        {
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger nkFactorial = 1;

            for (int i = 1; i <= n; i++)
            {
                nFactorial = nFactorial * (ulong)i;

                if (i <= k)
                {
                    kFactorial = kFactorial * (ulong)i;
                }
            }

            int nMinusK = n - k;

            for (int i = 1; i <= nMinusK; i++)
            {
                nkFactorial = nkFactorial * (ulong)i;
            }

            BigInteger result = nFactorial / (kFactorial * nkFactorial);

            return result;
        }
    }
}
