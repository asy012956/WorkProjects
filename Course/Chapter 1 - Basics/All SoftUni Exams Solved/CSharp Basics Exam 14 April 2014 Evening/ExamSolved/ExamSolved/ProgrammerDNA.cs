using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class ProgrammerDNA
    {
        public void ProgrammerDNASolved()
        {
            int N = int.Parse(Console.ReadLine()); //length of DNA chain
            char startingLetter = Convert.ToChar(Console.ReadLine());
            int dnaSize = 7;

            while (N > 0)
            {
                //create top line
                string dots = new string('.', dnaSize / 2);
                Console.WriteLine("{0}{1}{2}", dots, startingLetter, dots);
                N--;
                //create top half
                startingLetter++;
                if (startingLetter == 'H')
                {
                    startingLetter = 'A';
                }
                for (int i = 0; i < dnaSize / 2; i++)
                {
                    string topDots = new string('.', dnaSize / 2 - i - 1);
                    string topLetters = string.Empty;
                    for (int j = 0; j < dnaSize / 2 + (i * 2); j++)
                    {
                        topLetters = topLetters + startingLetter;
                        startingLetter++;
                        if (startingLetter == 'H')
                        {
                            startingLetter = 'A';
                        }
                    }

                    Console.WriteLine("{0}{1}{2}", topDots, topLetters, topDots);
                    N--;

                    if (N <= 0)
                    {
                        break;
                    }
                }

                if (N > 0)
                {
                    //bottom half
                    for (int i = 0; i < dnaSize / 2; i++)
                    {
                        string bottomDots = new string('.', i + 1);
                        string bottomLetters = string.Empty;
                        for (int j = 0; j < dnaSize - (2 * (i + 1)); j++)
                        {
                            bottomLetters = bottomLetters + startingLetter;
                            startingLetter++;
                            if (startingLetter == 'H')
                            {
                                startingLetter = 'A';
                            }

                        }
                        Console.WriteLine("{0}{1}{2}", bottomDots, bottomLetters, bottomDots);
                        N--;

                        if (N <= 0)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
