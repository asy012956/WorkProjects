using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem4
    {
        public void MaximalSequence(string input)
        {
            //Write a program that finds the maximal sequence of equal elements in an array.

            string[] inputSplit = input.Split(new string[]{", "}, StringSplitOptions.RemoveEmptyEntries);
            int[] intArray = new int[inputSplit.Length];  
            
            for (int i = 0; i < inputSplit.Length; i++)
            {
                intArray[i] = Convert.ToInt32(inputSplit[i]);
            }

            //int[] array = new int [] { 4, 4, 4, 4, 3, 3, 1, 0, 2, 1, 1, 1 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            int longestSequence = 1;
            int currentSequence = 1;
            int maxIndex = 0;

            for (int i = 1; i < intArray.Length; i++)
            {
                currentSequence = intArray[i - 1] == intArray[i] ? currentSequence + 1 : 1; 

                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    maxIndex = i - currentSequence + 1;
                }
            }
            
            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write(intArray[maxIndex + 1] + " ");
            }
                Console.WriteLine();
        }
    }
}
