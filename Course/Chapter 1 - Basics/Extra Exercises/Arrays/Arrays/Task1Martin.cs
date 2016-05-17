using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Task1Martin
    {
        public void Task1()
        {
            string input = Console.ReadLine(); //1a2a3a4a5a
            string[] newInput = input.Split(new string[] { "a" }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArray = new int[newInput.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(newInput[i]);
            }

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.Write(intArray[i] + " ");
            //}

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] * (-1) + " ");
            }
        }
    }
}
