using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Problem1
    {
        //Write a program that enters from the console a positive integer n and prints all the numbers
        //from 1 to n, on a single line, separated by a space.

        //Main method

        //int n = int.Parse(Console.ReadLine());
        //Problem1 problem1Runner = new Problem1();
        //string problem1Result = problem1Runner.Problem1Solution(n);
        //Console.WriteLine(problem1Result);

        public string Problem1Solution(int n)
        {
            string result = string.Empty;

            if (n <= 0)
            {
                Console.WriteLine("Invalid integer entered!");
            }

            else if (n == 1)
            {
                Console.WriteLine("1");
            }

            else
            {
                for (int i = 1; i <= n; i++)
                {

                    result = result + i + " ";
                }
            }

            return result;
        }

        //int n = int.Parse(Console.ReadLine()); //enter n
        
    }
}
