using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Problem3
    {
        //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
        //the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
        //The input starts by the number n(alone in a line) followed by n lines, each holding an integer number.

        //Main method

        //int n = int.Parse(Console.ReadLine());
        //Problem3 problem3Runner = new Problem3();
        //problem3Runner.Numbers(n);

        public void Numbers(int n)
        {

            if (n <= 0)
            {
                Console.WriteLine("Wrong integer entered!");
            }

            else if (n == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("1");
                }
            }


            else
            {
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                int min = numbers.Min();
                int max = numbers.Max();
                int sum = numbers.Sum();
                double average = Math.Round(numbers.Average(), 2);
                Console.WriteLine("min = {0}", min);
                Console.WriteLine("max = {0}", max);
                Console.WriteLine("sum = {0}", sum);
                Console.WriteLine("avg = {0:F2}", average);
            }
        }
    }
}
