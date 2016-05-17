using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem10
    {
        public void FindSumInArray()
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present).

            //create array
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //enter sum 
            int sumWanted = int.Parse(Console.ReadLine());

            //find sum in array
            int sum = 0;
            bool solution = false;
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = i; j < arraySize; j++)
                {
                    sum = sum + array[j];

                    if (sum == sumWanted)
                    {
                        solution = true;

                        for (int sumMember = i; sumMember <= j; sumMember++)
                        {
                            Console.Write("{0} ", array[sumMember]);
                        }

                        Console.WriteLine();
                    }

                }

                sum = 0;
            }

            if (solution == false)
            {
                Console.WriteLine("No such sum found!");
            }
        }
    }
}
