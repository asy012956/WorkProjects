using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Task3Martin
    {
        public void Task3()
        {
            int number = int.Parse(Console.ReadLine());
            string input = string.Empty;
            string workInput = string.Empty;
            float average = 0f;
            int counter = 0;
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                workInput = Console.ReadLine();
                input = input + workInput + " ";
            }

            //Console.WriteLine(input);

            string[] stringArray = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArray = new int[stringArray.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(stringArray[i]);
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                sum = sum + intArray[i];
                counter++;
            }

            average = sum / (float)counter;

            Console.WriteLine(average);
        }
    }
}
