using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExercisesSolutions
{
    public class EncryptedMatrix
    {
        public void SolveEncryptedMatrix()
        {
            string input = Console.ReadLine(); // S

            int[] inputToNumber = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                int intLetter = (int)letter;
                intLetter = intLetter % 10;
                inputToNumber[i] = intLetter;
            }

            List<int> encryptedNumbers = new List<int>();

            for (int i = 0; i < inputToNumber.Length; i++)
            {
                int digit = inputToNumber[i];

                if (digit % 2 == 0)
                {
                    digit = digit * digit;
                }
                else
                {
                    if (inputToNumber.Length > 1)
                    {
                        if (i == 0)
                        {
                            digit += inputToNumber[i + 1];
                        }
                        if (i == inputToNumber.Length - 1)
                        {
                            digit += inputToNumber[i - 1];
                        }
                        else
                        {
                            digit += inputToNumber[i - 1] + inputToNumber[i + 1];
                        }
                    }

                    if (i == 0 && inputToNumber.Length > 1)
                    {
                        digit = digit + inputToNumber[1];
                    }
                    else if (i == 0)
                    {
                        digit = digit + 0;
                    }
                    else if (i == inputToNumber.Length - 1)
                    {
                        digit = digit + inputToNumber[inputToNumber.Length - 2];
                    }
                    else
                    {
                        digit = digit + inputToNumber[i - 1] + inputToNumber[i + 1];
                    }
                }

                if (digit >= 10)
                {
                    int[] array = new int[2];
                    int counter = 1;

                    while (digit != 0)
                    {
                        int newDigit = digit % 10;
                        array[counter] = newDigit;
                        counter--;
                        digit = digit / 10;
                    }

                    for (int a = 0; a < 2; a++)
                    {
                        encryptedNumbers.Add(array[a]);
                    }
                }
                else
                {
                    encryptedNumbers.Add(digit);
                }
            }

            int[,] matrix = new int[encryptedNumbers.Count, encryptedNumbers.Count];
            string direction = Console.ReadLine();
            if (direction == "\\")
            {
                for (int i = 0; i < encryptedNumbers.Count; i++)
                {
                    matrix[i, i] = encryptedNumbers[i];
                }
            }

            if (direction == "/")
            {
                for (int row = encryptedNumbers.Count - 1, col = 0; row >= 0; row--, col++)
                {
                    matrix[row, col] = encryptedNumbers[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
