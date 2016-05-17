using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Task2Martin
    {
        public void Task2()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string allInput = input1 + " " + input2 + " " + input3;
            //Console.WriteLine(allInput);
            string[] stringArray = allInput.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    Console.Write(stringArray[i]);
            //}

            int[] intArray = new int[stringArray.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(stringArray[i]);
            }

            int sum = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                sum = sum + intArray[i];
            }

            Console.WriteLine(sum);

        }
    }
}
