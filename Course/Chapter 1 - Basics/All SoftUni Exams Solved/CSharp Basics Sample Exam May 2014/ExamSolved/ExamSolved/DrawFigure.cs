using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class DrawFigure
    {
        public void DrawFigureSolved()
        {
            int N = int.Parse(Console.ReadLine());

            //create top line
            string topLine = new string('*', N);
            Console.WriteLine(topLine);

            //create top half
            for (int i = 0, j = 1; i < (N / 2) - 1; i++, j++)
            {
                string dots = new string('.', j);
                string topHalfStars = new string('*', N - (2 * j));
                Console.WriteLine("{0}{1}{2}", dots, topHalfStars, dots);
            }

            //create middle line
            string midLineDots = new string('.', N / 2);
            string midLineStar = new string('*', 1);
            Console.WriteLine("{0}{1}{2}", midLineDots, midLineStar, midLineDots);

            //create bottom half
            for (int i = 0, j = 1; i < (N / 2) - 1; i++, j++)
            {
                string bottomHalfDots = new string('.', (N / 2) - j);
                string bottomHalfStars = new string('*', 1 + (2 * j));
                Console.WriteLine("{0}{1}{2}", bottomHalfDots, bottomHalfStars, bottomHalfDots);
            }

            //create bottom line
            Console.WriteLine(topLine);
        }
    }
}
