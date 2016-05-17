using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTasks
{
    class StringToInt
    {
        public void StringCalculate()
        {
            string input = "20+1015-50";
            int result = 0;
            int j = 0;
            string[] numbers = input.Split('+', '-');
            string[] signs = new string[numbers.Length-1];
            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] == '+') || (input[i] == '-'))
                {
                    signs[j] = input[i].ToString();
                    j++;
                }
            }

            result = int.Parse(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);

                if (signs[i - 1] == "+")
                {
                    result = result + number;
                }

                if (signs[i - 1] == "-")
                {
                    result = result - number;
                }
            }

            Console.WriteLine(result);
        }
    }
}
