using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class PandaScotlandFlag
    {
        public void PandaScotlandFlagSolved(int N)
        {
            //create top line
            char letter = 'A';
            string topGrids = new string('#', N - 2);
            Console.WriteLine("{0}{1}{2}", letter, topGrids, ++letter);

            //create top half
            for (int i = 0, j = 1; i < (N / 2) - 1; i++, j++)
            {
                string tilda = new string('~', j);
                string topHalfGrids = new string('#', (N - 2) - 2 * j);
                if (letter >= 'Z')
                {
                    letter = '@';
                }
                Console.WriteLine("{0}{1}{2}{3}{4}", tilda, ++letter, topHalfGrids, ++letter, tilda);
            }

            //create middle line
            string dash = new string('-', N / 2);
            if (letter >= 'Z')
            {
                letter = '@';
            }
            Console.WriteLine("{0}{1}{2}", dash, ++letter, dash);
                        
            //create bottom half
            for (int i = 0, j = 1; i < (N / 2) - 1; i++, j = j + 2)
            {
                string bottomTilda = new string('~', ((N / 2) - 1) - i);
                string bottomDash = new string('#', j);
                Console.Write(bottomTilda);
                if (letter >= 'Z')
                {
                    letter = '@';
                }
                Console.Write(++letter);
                Console.Write(bottomDash);
                if (letter >= 'Z')
                {
                    letter = '@';
                }
                Console.Write(++letter);
                Console.Write(bottomTilda);
                Console.WriteLine();
            }

            //create bottom line
            string bottomGrids = new string('#', N - 2);
            if (letter >= 'Z')
            {
                letter = '@';
            }
            Console.WriteLine("{0}{1}{2}", ++letter, bottomGrids, ++letter);
        }
    }
}
