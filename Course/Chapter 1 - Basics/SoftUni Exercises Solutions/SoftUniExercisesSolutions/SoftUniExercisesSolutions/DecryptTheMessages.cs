using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExercisesSolutions
{
    public class DecryptTheMessages
    {
        public void SolveDecryptTheMessages()
        {
            List<string> inputList = new List<string>(); 
            string decodedMessage = string.Empty;
            string start = Console.ReadLine();

            if (start == "start" || start == "START") //start.ToLower() == "start"
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if ((input != "end" && input != "END" && input.Length > 0)) 
                    {
                        inputList.Add(input);
                    }
                    else if (input == "end" || input == "END")
                    {
                        break;
                    }
                }
            }

            if (inputList.Count == 0)
            {
                Console.WriteLine("No message received.");
            }

            if (inputList.Count > 0)
            {
                Console.WriteLine("Total number of messages: {0}", inputList.Count);
            }

            char decodedLetter = 'a';

            for (int i = 0; i < inputList.Count; i++)
            {
                for (int k = 0; k < inputList[i].Length; k++)
                {
                    char letter = inputList[i][k];

                    if ((letter >= 65 && letter < 78) || (letter >= 97 && letter < 110))
                    {
                        decodedLetter = (char)((int)letter + 13);
                    }
                    else if (letter >= 78 && letter <= 90)
                    {
                        decodedLetter = (char)((int)letter - 13);
                    }

                    if (letter == 'N')
                    {
                        decodedLetter = 'A';
                    }
                    else if (letter == 'n')
                    {
                        decodedLetter = 'a';
                    }
                    else if (letter == 'O')
                    {
                        decodedLetter = 'B';
                    }
                    else if (letter == 'o')
                    {
                        decodedLetter = 'b';
                    }
                    else if (letter == 'P')
                    {
                        decodedLetter = 'C';
                    }
                    else if (letter == 'p')
                    {
                        decodedLetter = 'c';
                    }
                    else if (letter == 'Q')
                    {
                        decodedLetter = 'D';
                    }
                    else if (letter == 'q')
                    {
                        decodedLetter = 'd';
                    }
                    else if (letter == 'R')
                    {
                        decodedLetter = 'E';
                    }
                    else if (letter == 'r')
                    {
                        decodedLetter = 'e';
                    }
                    else if (letter == 'S')
                    {
                        decodedLetter = 'F';
                    }
                    else if (letter == 's')
                    {
                        decodedLetter = 'f';
                    }
                    else if (letter == 'T')
                    {
                        decodedLetter = 'G';
                    }
                    else if (letter == 't')
                    {
                        decodedLetter = 'g';
                    }
                    else if (letter == 'U')
                    {
                        decodedLetter = 'H';
                    }
                    else if (letter == 'u')
                    {
                        decodedLetter = 'h';
                    }
                    else if (letter == 'V')
                    {
                        decodedLetter = 'I';
                    }
                    else if (letter == 'v')
                    {
                        decodedLetter = 'i';
                    }
                    else if (letter == 'W')
                    {
                        decodedLetter = 'J';
                    }
                    else if (letter == 'w')
                    {
                        decodedLetter = 'j';
                    }
                    else if (letter == 'X')
                    {
                        decodedLetter = 'K';
                    }
                    else if (letter == 'x')
                    {
                        decodedLetter = 'k';
                    }
                    else if (letter == 'Y')
                    {
                        decodedLetter = 'L';
                    }
                    else if (letter == 'y')
                    {
                        decodedLetter = 'l';
                    }
                    else if (letter == 'Z')
                    {
                        decodedLetter = 'M';
                    }
                    else if (letter == 'z')
                    {
                        decodedLetter = 'm';
                    }
                    else if (letter == 'A')
                    {
                        decodedLetter = 'N';
                    }
                    else if (letter == 'a')
                    {
                        decodedLetter = 'n';
                    }
                    else if (letter == 'B')
                    {
                        decodedLetter = 'O';
                    }
                    else if (letter == 'b')
                    {
                        decodedLetter = 'o';
                    }
                    else if (letter == 'C')
                    {
                        decodedLetter = 'P';
                    }
                    else if (letter == 'c')
                    {
                        decodedLetter = 'p';
                    }
                    else if (letter == 'D')
                    {
                        decodedLetter = 'Q';
                    }
                    else if (letter == 'd')
                    {
                        decodedLetter = 'Q';
                    }
                    else if (letter == 'E')
                    {
                        decodedLetter = 'R';
                    }
                    else if (letter == 'e')
                    {
                        decodedLetter = 'r';
                    }
                    else if (letter == 'F')
                    {
                        decodedLetter = 'S';
                    }
                    else if (letter == 'f')
                    {
                        decodedLetter = 's';
                    }
                    else if (letter == 'G')
                    {
                        decodedLetter = 'T';
                    }
                    else if (letter == 'g')
                    {
                        decodedLetter = 't';
                    }
                    else if (letter == 'H')
                    {
                        decodedLetter = 'U';
                    }
                    else if (letter == 'h')
                    {
                        decodedLetter = 'u';
                    }
                    else if (letter == 'I')
                    {
                        decodedLetter = 'V';
                    }
                    else if (letter == 'i')
                    {
                        decodedLetter = 'v';
                    }
                    else if (letter == 'J')
                    {
                        decodedLetter = 'W';
                    }
                    else if (letter == 'j')
                    {
                        decodedLetter = 'w';
                    }
                    else if (letter == 'K')
                    {
                        decodedLetter = 'X';
                    }
                    else if (letter == 'k')
                    {
                        decodedLetter = 'x';
                    }
                    else if (letter == 'L')
                    {
                        decodedLetter = 'Y';
                    }
                    else if (letter == 'l')
                    {
                        decodedLetter = 'y';
                    }
                    else if (letter == 'M')
                    {
                        decodedLetter = 'Z';
                    }
                    else if (letter == 'm')
                    {
                        decodedLetter = 'z';
                    }
                    else if (letter == '+')
                    {
                        decodedLetter = ' ';
                    }
                    else if (letter == '%')
                    {
                        decodedLetter = ',';
                    }
                    else if (letter == '&')
                    {
                        decodedLetter = '.';
                    }
                    else if (letter == '#')
                    {
                        decodedLetter = '?';
                    }
                    else if (letter == '$')
                    {
                        decodedLetter = '!';
                    }
                    else if (letter == '0')
                    {
                        decodedLetter = '0';
                    }
                    else if (letter == '1')
                    {
                        decodedLetter = '1';
                    }
                    else if (letter == '2')
                    {
                        decodedLetter = '2';
                    }
                    else if (letter == '3')
                    {
                        decodedLetter = '3';
                    }
                    else if (letter == '4')
                    {
                        decodedLetter = '4';
                    }
                    else if (letter == '5')
                    {
                        decodedLetter = '5';
                    }
                    else if (letter == '6')
                    {
                        decodedLetter = '6';
                    }
                    else if (letter == '7')
                    {
                        decodedLetter = '7';
                    }
                    else if (letter == '8')
                    {
                        decodedLetter = '8';
                    }
                    else if (letter == '9')
                    {
                        decodedLetter = '9';
                    }

                    decodedMessage = decodedMessage + decodedLetter;
                }

                char[] charArray = decodedMessage.ToCharArray(); 
                Array.Reverse(charArray);
                string result = string.Empty;
                foreach (char item in charArray)
                {
                    result = result + item;
                }
                Console.WriteLine(result);
                decodedMessage = string.Empty;
            }
        }
    }
}
