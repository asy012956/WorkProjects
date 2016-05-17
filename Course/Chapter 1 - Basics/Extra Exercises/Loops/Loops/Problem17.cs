using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Problem17
    {
        public int CalculateGCD(int a, int b)
        {

            //Write a program that calculates the greatest common divisor(GCD) of given two integers a and b.
            //Use the Euclidean algorithm (find it in Internet).

            // Main method
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Problem17 problem17Runner = new Problem17();
            //int problem17Result = problem17Runner.CalculateGCD(a, b);
            //Console.WriteLine(problem17Result);


            int quotient = 0;
            int remainder = 1;
            while (remainder != 0)
            {
                remainder = a % b;
                quotient = a / b;
                a = b;
                b = remainder;
            }

            return a;
        }
    }
}
