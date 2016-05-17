using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem6
    {
        public int MaximalKSum()
        {
            //Write a program that reads two integer numbers N and K and an array of N elements from the console.
            //Find in the array those K elements that have maximal sum.

            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = 0;
            int currentSum = 0;
            int currentPosition = 1;

            for (int i = 1; i < array.Length; i++)
            {
                currentSum = array[i - 1] + array[i]; 

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    currentPosition = i - currentSum + 1;
                }
            }

            return maxSum;
        }
    }
}
