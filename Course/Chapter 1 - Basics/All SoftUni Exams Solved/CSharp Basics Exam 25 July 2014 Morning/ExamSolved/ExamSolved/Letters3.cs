using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Letters3
    {
        public Letters3Attributes Letters3Solved(string input)
        {
            Letters3Attributes output = new Letters3Attributes();
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

            output.LettersSum = sumLetters;
            output.NumbersSum = sumNumbers;
            output.SymbolsSum = sumSymbols;

            return output;
        }
    }
}
