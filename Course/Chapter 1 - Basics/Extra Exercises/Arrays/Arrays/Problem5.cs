using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem5
    {
        public void MaximalIncreasingSequence(string input)
        {
            //Write a program that finds the maximal increasing sequence in an array.

            string[] inputSplit = input.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);
            int[] intArray = new int[inputSplit.Length];

            for (int i = 0; i < inputSplit.Length; i++)
            {
                intArray[i] = Convert.ToInt32(inputSplit[i]);
            }

            //int[] array = {3, 1, 4, 5, 6, 9, 4, 0};

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            int increasingSequence = 1;
            int currentSequence = 1;
            int maxIndex = 0;

            for (int i = 1; i < intArray.Length; i++)
            {
                currentSequence = intArray[i - 1] < intArray[i] ? currentSequence + 1 : 1;

                if (currentSequence > increasingSequence)
                {
                    increasingSequence = currentSequence;
                    maxIndex = i - currentSequence + 1;
                }
            }

            for (int i = 0; i < increasingSequence; i++)
            {
                Console.Write(intArray[maxIndex + i] + " ");
            }

            Console.WriteLine();

        }
    }
}




