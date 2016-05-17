using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem11
    {
        public void BinarySearch()
        {
            //Write a program that finds the index of given element in a sorted array of integers 
            //by using the Binary search algorithm.

            //create array
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //element to search for
            int element = int.Parse(Console.ReadLine());

            //sort array
            Array.Sort(array); // 1  3  4  7  8  9  12  15 18
            //Array.BinarySearch(array, element);

            FindIndex(array, 0, array.Length, 4);

        }

        public void FindIndex(int[] array, int start, int end, int element)
        {
            if (end <= start)
            {
                Console.WriteLine("Element not found!");
                return;
            }

            int middle = start + ((end - start) / 2); //4 
            
            if (element < array[middle])
            {
                FindIndex(array, start, middle - 1, element);
                return;
            }

            else if (element > array[middle])
            {
                FindIndex(array, middle + 1, end, element);
                return;
            }

            else
            {
                Console.Write(element);
                Console.Write(" " + middle);
            }

        }
    }
}
