using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    public class Problem14
    {
        public string DecimalToBinary()
        {
            //Using loops write a program that converts an integer number to its binary representation.
            //The input is entered as long. The output should be a variable of type string.
            //Do not use the built-in .NET functionality.

            //Main method
            //Problem14 problem14Runner = new Problem14();
            //string result = problem14Runner.DecimalToBinary();
            //Console.WriteLine(result);

            long decimalNumber = long.Parse(Console.ReadLine());
            string workNumber = string.Empty;
            long workDecimal = decimalNumber;
            long remainder = 0;
            while (workDecimal != 0)
            {
                remainder = workDecimal % 2;
                if (remainder == 0)
                {
                    workNumber = workNumber + remainder;
                }

                else
                {
                    remainder = 1;
                    workNumber = workNumber + remainder;
                }

                workDecimal = workDecimal / 2;
            }

            char[] reverse = workNumber.ToCharArray();

            Array.Reverse(reverse);

            return new string (reverse);
        }
    }
}
