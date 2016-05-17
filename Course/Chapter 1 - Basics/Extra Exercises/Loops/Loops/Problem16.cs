using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    public class Problem16
    {
        public string DecimalToHex()
        {
            //Using loops write a program that converts an integer number to its hexadecimal representation.
            //The input is entered as long. The output should be a variable of type string.
            //Do not use the built-in .NET functionality.

            // Main method

            //Problem16 problem16Runner = new Problem16();
            //string problem16Result = problem16Runner.DecimalToHex();
            //Console.WriteLine(problem16Result);

            long decimalNumber = long.Parse(Console.ReadLine()); //1234
            string result = string.Empty;
            long remainder = 0;
            string num = string.Empty;
            while (decimalNumber != 0)
            {
                remainder = decimalNumber % 16;
                switch (remainder)
                {
                    case 10: num = "A"; break;
                    case 11: num = "B"; break;
                    case 12: num = "C"; break;
                    case 13: num = "D"; break;
                    case 14: num = "E"; break;
                    case 15: num = "F"; break;
                    default:  num = Convert.ToString(remainder); break;
                }

                result = result + num;

                decimalNumber = decimalNumber / 16;
            }

            char[] finalResult = result.ToCharArray();
            Array.Reverse(finalResult); 

            return new string (finalResult);
        }
    }
}
