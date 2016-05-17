using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem8
    {
        public void MaximalSum()
        {
            //Write a program that finds the sequence of maximal sum in given array.

            //create array
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //1, 2, -5, 4, 0, 9, 8, -3;

            int maximalSum = array[0];
            int currentSum = array[0];
            int start = 0;
            int end = 0;
            int temporaryStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                currentSum = currentSum + array[i];

                if (currentSum < array[i])
                {
                    currentSum = array[i];
                    temporaryStart = i;
                }

                if (currentSum > maximalSum)
                {
                    maximalSum = currentSum;
                    start = temporaryStart;
                    end = i;
                }
            }

            for (int i = start; i <= end; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
