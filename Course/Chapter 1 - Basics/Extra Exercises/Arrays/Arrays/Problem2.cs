using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem2
    {
        public bool CompareArrays(int n)
        {
            //Write a program that reads two integer arrays from the console and compares them element by element.

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            bool arraysAreEqual = true;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    arraysAreEqual = false;
                }
            }

            return arraysAreEqual;
        }
    }
}
