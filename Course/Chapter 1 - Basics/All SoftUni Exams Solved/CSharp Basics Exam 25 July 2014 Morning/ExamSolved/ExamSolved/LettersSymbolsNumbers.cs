using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class LettersSymbolsNumbers
    {
        public List<int> LettersSymbolsNumbersSolved(int N)
        {
            List<int> output = new List<int>();
            int sumLetters = 0;
            int sumNumbers = 0;
            int sumSymbols = 0;
            string inputNoEmptyEntries = string.Empty;

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                input = input.ToUpper();
                string[] array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string member in array)
                {
                    inputNoEmptyEntries = inputNoEmptyEntries + member;
                }

                for (int j = 0; j < inputNoEmptyEntries.Length; j++)
                {
                    char currentChar = inputNoEmptyEntries[j];
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

                inputNoEmptyEntries = string.Empty;
            }

            output.Add(sumLetters);
            output.Add(sumNumbers);
            output.Add(sumSymbols);

            return output;
        }
    }
}
