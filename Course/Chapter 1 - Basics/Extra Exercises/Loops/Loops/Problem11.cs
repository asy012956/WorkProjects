using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Problem11
    {
        public void RandomNumbersInRange()
        {
            //Write a program that enters 3 integers n, min and max (min != max) 
            //and prints n random numbers in the range [min...max].

            //Main method
            //Problem11 problem11Runner = new Problem11();
            //problem11Runner.RandomNumbersInRange();

            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random randomNumber = new Random();
            if (min != max)
            {
                for (int i = 0; i < n; i++)
                {
                    int result = randomNumber.Next(min, max);
                    Console.Write(result + " ");
                }

            }

            else
            {
                Console.WriteLine("Wrong Input!");
            }
        }
    }
}
