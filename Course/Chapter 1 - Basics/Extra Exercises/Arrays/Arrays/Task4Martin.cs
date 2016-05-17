using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Task4Martin
    {
        public void Task4()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string allInput = input1 + " " + input2 + " " + input3;
            //Console.WriteLine(allInput);

            string[] stringArray = allInput.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArray = new int[stringArray.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(stringArray[i]);
            }

            int max = intArray[0]; // or Int32.MinValue; 

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > max)
                {
                    max = intArray[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}
