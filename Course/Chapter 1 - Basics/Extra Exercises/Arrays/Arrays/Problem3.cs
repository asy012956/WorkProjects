using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Problem3
    {
        public bool CompareCharArrays(int n)
        {
            //Write a program that reads two integer arrays from the console and compares them element by element.

            char[] array1 = new char[n];
            char[] array2 = new char[n];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToChar(Console.ReadLine());
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Convert.ToChar(Console.ReadLine());
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
