using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class SequenceOfKNumbers
    {
        public string SequenceOfKNumbersSolved(string input, int k)
        {
            input = input + " " + short.MaxValue;
            string[] inputToArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string output = string.Empty;
            int counter = 1;
            int firstNumber = int.Parse(inputToArray[0]);
            for (int i = 1; i < inputToArray.Length; i++)
            {
                int number = int.Parse(inputToArray[i]);
                if (number == firstNumber)
                {
                    counter++;
                }
                else
                {
                    for (int j = 0; j < counter % k; j++)
                    {
                        output = output + firstNumber + " ";
                    }

                    counter = 1;
                }

                firstNumber = number;
            }

            string finalOutput = string.Empty;
            for (int i = 0; i < output.Length - 1; i++)
            {
                finalOutput = finalOutput + output[i];
            }

            return finalOutput;
        }
    }
}
