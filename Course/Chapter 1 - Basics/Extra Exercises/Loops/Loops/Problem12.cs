using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Problem12
    {
        public void RandomNumbers1N()
        {
            //Write a program that enters in integer n and prints the numbers 1, 2, …, n 
            //in random order.

            //Main method
            //Problem12 problem12Runner = new Problem12();
            //problem12Runner.RandomNumbers1N();

            int n = int.Parse(Console.ReadLine());
            Random randomNumber = new Random();
            for (int i = 0; i < n; i++)
            {
                int result = randomNumber.Next(1, n);
                Console.Write(result + " ");
            }
        }
    }
}
