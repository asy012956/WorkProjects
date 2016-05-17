using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Illuminati
    {
        public IlluminatiAddOn IlluminatiSolved(string input)
        {
            IlluminatiAddOn result = new IlluminatiAddOn();
            result.NumberOfVowels = 0;
            result.SumOfVowels = 0;
            string[] inputToArray = input.Split(' ');
            string inputString = string.Empty;
            foreach (string item in inputToArray)
            {
                inputString = inputString + item;
            }

            foreach (char letter in inputString)
            {
                if (letter == 'A' || letter == 'a')
                {
                    result.NumberOfVowels++;
                    result.SumOfVowels = result.SumOfVowels + 65;
                }
                else if (letter == 'E' || letter == 'e')
                {
                    result.NumberOfVowels++;
                    result.SumOfVowels = result.SumOfVowels + 69;
                }
                else if (letter == 'I' || letter == 'i')
                {
                    result.NumberOfVowels++;
                    result.SumOfVowels = result.SumOfVowels + 73;
                }
                else if (letter == 'O' || letter == 'o')
                {
                    result.NumberOfVowels++;
                    result.SumOfVowels = result.SumOfVowels + 79;
                }
                else if (letter == 'U' || letter == 'u')
                {
                    result.NumberOfVowels++;
                    result.SumOfVowels = result.SumOfVowels + 85;
                }
            }

            return result;
        }
    }
}
