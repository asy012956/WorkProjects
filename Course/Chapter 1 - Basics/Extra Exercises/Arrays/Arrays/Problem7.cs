using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem7
    {
        public void SelectionSort()
        {
            //Sorting an array means to arrange its elements in increasing order. 
            //Write a program to sort an array.
            //Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
            //find the smallest from the rest, move it at the second position, etc.

            //Enter an array
            int arraySize = int.Parse(Console.ReadLine()); //7
            int[] array = new int[arraySize]; //7
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine()); //1 3 4 8 2 0 6 7
            }


            //we will now sort the array
            int smallestValue = int.MaxValue;
            int minIndex = 0;
            int temp = 0;

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = i; j < arraySize; j++)
                {
                    if (smallestValue > array[j])
                    {
                        smallestValue = array[j];
                        minIndex = j;
                    }
                }

                temp = array[i];
                array[i] = smallestValue;
                array[minIndex] = temp;
                smallestValue = int.MaxValue;
            }

            foreach (int value in array)
            {
                Console.Write(value + " ");
            }

            //Array.Sort(array);
            //foreach (int value in array)
            //{
            //    Console.Write(value + " ");
            //}
        }
    }
}
