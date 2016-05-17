using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Letters2
    {
        public List<int> Letters2Solved(string input)
        {
            List<int> output = new List<int>();
            int sumLetters = 0;
            int sumNumbers = 0;
            int sumSymbols = 0;
            string inputNoEmptyEntries = string.Empty;

            input = input.ToUpper();
            inputNoEmptyEntries = input.Replace(" ", "");

            for (int i = 0; i < inputNoEmptyEntries.Length; i++)
            {
                char currentChar = inputNoEmptyEntries[i];
                if ((currentChar >= 'A' && currentChar <= 'Z'))
                {
                    sumLetters = sumLetters + ((currentChar - 'A' + 1) * 10);
                }
                else if (currentChar >= '0' && currentChar <= '9')
                {
                    sumNumbers = sumNumbers + ((currentChar - '0') * 20);
                }
                else
                {
                    sumSymbols = sumSymbols + 200;
                }
            }

            output.Add(sumLetters);
            output.Add(sumNumbers);
            output.Add(sumSymbols);

            return output;
        }
    }
}
