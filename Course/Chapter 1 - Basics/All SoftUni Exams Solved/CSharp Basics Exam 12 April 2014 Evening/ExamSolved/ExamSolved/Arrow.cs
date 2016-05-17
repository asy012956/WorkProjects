using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Arrow
    {
        public void ArrowSolved()
        {
            int N = int.Parse(Console.ReadLine());

            //create top line
            string topDots = new string('.', (N - 1) / 2);
            string numberSigns = new string('#', N);
            Console.WriteLine("{0}{1}{2}", topDots, numberSigns, topDots);

            //create top part
            string extTopPartDots = new string('.', (N - 1) / 2);
            string numberSign = new string('#', 1);
            string intTopPartDots = new string('.', N - 2);
            for (int i = 0; i < N - 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", extTopPartDots, numberSign, intTopPartDots, numberSign, extTopPartDots);
            }

            //create mid line
            string midNumberSign = new string('#', (N / 2) + 1);
            string midDots = new string('.', N - 2);
            Console.WriteLine("{0}{1}{2}", midNumberSign, midDots, midNumberSign);

            //create bottom half
            int botExtDotsNumber = 1;
            int botIntDotsNumber = (2 * N) - 5;
            string botNumberSign = new string('#', 1);
            for (int i = 0; i < N - 2; i++)
            {
                string botExtDots = new string('.', botExtDotsNumber);
                string botIntDots = new string('.', botIntDotsNumber);
                Console.WriteLine("{0}{1}{2}{3}{4}", botExtDots, botNumberSign, botIntDots, botNumberSign, botExtDots);
                botExtDotsNumber++;
                botIntDotsNumber = botIntDotsNumber - 2;
                if (botIntDotsNumber < 0)
                {
                    botIntDotsNumber = 0;
                }
            }

            //create bottom line
            string bottomLineDots = new string('.', N - 1);
            string bottomNumberSign = new string('#', 1);
            Console.WriteLine("{0}{1}{2}", bottomLineDots, bottomNumberSign, bottomLineDots);
        }
    }
}
