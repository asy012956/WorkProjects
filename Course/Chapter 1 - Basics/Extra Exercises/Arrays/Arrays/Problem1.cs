using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem1
    {
        public void AllocateArray()
        {
            //Write a program that allocates array of 20 integers and initializes 
            //each element by its index multiplied by 5.
            //Print the obtained array on the console.

            int[] integerArray = new int[20];
            for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = i * 5;
            }

            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.Write(integerArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
