using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class SumOfElements
    {
        public SumOfElementsAddOn SumOfElementsSolved(string input)
        {
            string[] inputToArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[inputToArray.Length];
            for (int i = 0; i < inputToArray.Length; i++)
            {
                numbers[i] = int.Parse(inputToArray[i]);
            }

            SumOfElementsAddOn sum = new SumOfElementsAddOn();
            sum.Sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum.Sum = sum.Sum + numbers[j];
                    if (numbers[j] > max)
                    {
                        max = numbers[j];
                    }
                }

                sum.Sum = sum.Sum - numbers[i];
                if (sum.Sum == numbers[i])
                {
                    sum.Answer = "Yes";
                    return sum;
                }

                sum.Sum = 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sum.Sum = sum.Sum + numbers[i];
            }

            sum.Diff = sum.Sum - (2 * max);
            sum.Answer = "No";

            return sum;

        }
    }
}
