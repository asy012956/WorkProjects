using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    class Problem15
    {
        public double HexToDecimal()
        {
            //Using loops write a program that converts a hexadecimal integer number to its decimal form.
            //The input is entered as string. The output should be a variable of type long.
            //Do not use the built-in .NET functionality.

            //Main method
            //Problem15 problem15Runner = new Problem15();
            //double result = problem15Runner.HexToDecimal();
            //Console.WriteLine(result);

            string hexNumber = Console.ReadLine(); //1FEB
            int power = hexNumber.Length - 1;
            double result = 0;
            int num = 0;
            for (int i = 0; i < hexNumber.Length; i++)
            {
                char ch = hexNumber[i];
                switch (ch)
                {
                    case '1': num = 1; break; 
                    case '2': num = 2; break;
                    case '3': num = 3; break;
                    case '4': num = 4; break;
                    case '5': num = 5; break;
                    case '6': num = 6; break;
                    case '7': num = 7; break;
                    case '8': num = 8; break;
                    case '9': num = 9; break;
                    case 'A': num = 10; break;
                    case 'B': num = 11; break;
                    case 'C': num = 12; break;
                    case 'D': num = 13; break;
                    case 'E': num = 14; break;
                    case 'F': num = 15; break;
                }

                result = result + (num * (Math.Pow(16,power)));
                power--;
            }

            return result;
        }
    }
}
