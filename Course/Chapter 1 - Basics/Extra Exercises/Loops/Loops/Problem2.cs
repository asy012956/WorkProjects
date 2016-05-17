using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Problem2
    {
        //Write a program that enters from the console a positive integer n and prints
        //all the numbers from 1 to n not divisible by 3 or 7, on a single line, separated by a space.

        //Main method

        //int n = int.Parse(Console.ReadLine());
        //Problem2 problem2Runner = new Problem2();
        //string problem2Result = problem2Runner.Problem2Solution(n);
        //Console.WriteLine(problem2Result);

        public string Problem2Solution(int n)
        {
            string result = string.Empty;

            if (n <= 0)
            {
                Console.WriteLine("Wrong integer entered!");
            }

            else if (n == 1)
            {
                Console.WriteLine("1");
            }

            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 == 0 || i % 7 == 0)
                    {
                        continue;
                    }

                    result = result + i + " ";
                }
            }

            return result;
        }
    }
}
