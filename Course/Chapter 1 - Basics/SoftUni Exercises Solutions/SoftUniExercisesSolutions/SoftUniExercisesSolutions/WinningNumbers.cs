using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExercisesSolutions
{
    public class WinningNumbers
    {
        public void SolveWinningNumbers()
        {
            string input = Console.ReadLine();
            int lettersSum = 0;
            int letterValue = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                if (letter == 'a' || letter == 'A')
                {
                    letterValue = 1;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'b' || letter == 'B')
                {
                    letterValue = 2;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'c' || letter == 'C')
                {
                    letterValue = 3;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'd' || letter == 'D')
                {
                    letterValue = 4;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'e' || letter == 'E')
                {
                    letterValue = 5;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'f' || letter == 'F')
                {
                    letterValue = 6;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'g' || letter == 'G')
                {
                    letterValue = 7;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'h' || letter == 'H')
                {
                    letterValue = 8;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'i' || letter == 'I')
                {
                    letterValue = 9;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'j' || letter == 'J')
                {
                    letterValue = 10;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'k' || letter == 'K')
                {
                    letterValue = 11;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'l' || letter == 'L')
                {
                    letterValue = 12;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'm' || letter == 'M')
                {
                    letterValue = 13;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'n' || letter == 'N')
                {
                    letterValue = 14;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'o' || letter == 'O')
                {
                    letterValue = 15;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'p' || letter == 'P')
                {
                    letterValue = 16;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'q' || letter == 'Q')
                {
                    letterValue = 17;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'r' || letter == 'R')
                {
                    letterValue = 18;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 's' || letter == 'S')
                {
                    letterValue = 19;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 't' || letter == 'T')
                {
                    letterValue = 20;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'u' || letter == 'U')
                {
                    letterValue = 21;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'v' || letter == 'V')
                {
                    letterValue = 22;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'w' || letter == 'W')
                {
                    letterValue = 23;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'x' || letter == 'X')
                {
                    letterValue = 24;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'y' || letter == 'Y')
                {
                    letterValue = 25;
                    lettersSum = lettersSum + letterValue;
                }
                else if (letter == 'z' || letter == 'Z')
                {
                    letterValue = 26;
                    lettersSum = lettersSum + letterValue;
                }
            }

            for (int i = 100; i <= 999; i++)
            {
                int result1 = 1;
                int workInteger1 = i;
                while (workInteger1 != 0)
                {
                    int remainder1 = workInteger1 % 10;
                    result1 = result1 * remainder1;
                    workInteger1 = workInteger1 / 10;
                }

                for (int j = 100; j <= 999; j++)
                {
                    int result2 = 1;
                    int workInteger2 = j;
                    while (workInteger2 != 0)
                    {
                        int remainder2 = workInteger2 % 10;
                        result2 = result2 * remainder2;
                        workInteger2 = workInteger2 / 10;
                    }

                    if ((result2 == result1) && (result2 == lettersSum))
                    {
                        Console.WriteLine("{0}-{1}", i, j);
                    }
                }
            }
        }
    }
}
