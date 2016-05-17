using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Problem9
    {
        //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and 
        //prints a matrix like in the examples below. Use two nested loops.

        //Main method
        //int n = int.Parse(Console.ReadLine());
        //Problem9 problem9Runner = new Problem9();
        //    if ((n >= 1) && (n <= 20))
        //    {
        //        problem9Runner.Matrix(n);
        //    }

        //    else
        //    {
        //        Console.WriteLine("Wrong input!");
        //    }

        public void Matrix(int n)
        {
            int element = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int j = rows; j <= 2 * n; j++)
                {
                    if (element <= n)
                    {
                        Console.Write(j + " ");
                        element++;
                    }
                }

                Console.WriteLine();
                element = 1;
            }

            return;

        }
    }
}
