using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem9
    {
        public void FindFrequentNumber()
        {
            //Write a program that finds the most frequent number in an array.

            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine()); 
            }

            Array.Sort(array);

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

            int number = 0;
            int currentCount = 1;
            int maximalCount = int.MinValue;

            if (arraySize == 1)
            {
                maximalCount = 1;
                number = array[0];
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentCount++;
                }

                else
                {
                    currentCount = 1;
                }

                if (currentCount > maximalCount)
                {
                    maximalCount = currentCount;
                    number = array[i];
                }
            }

            Console.WriteLine("{0} ({1} times)", number, maximalCount);
        }
    }
}