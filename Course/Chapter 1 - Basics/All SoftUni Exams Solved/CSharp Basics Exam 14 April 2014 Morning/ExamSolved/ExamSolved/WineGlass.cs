using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class WineGlass
    {
        public void WineGlassSolved()
        {
            int N = int.Parse(Console.ReadLine());
            //create top half
            for (int i = 0; i < N / 2; i++)
            {
                string topDots = new string('.', i);
                string leftSlash = new string('\\', 1);
                string rightSlash = new string('/', 1);
                string topAsterisks = new string('*', N - 2 - (i * 2));
                Console.WriteLine("{0}{1}{2}{3}{4}", topDots, leftSlash, topAsterisks, rightSlash, topDots);
            }

            //create bottom half
            if (N < 12)
            {
                string bottomDots = new string('.', (N / 2 - 1));
                string bottomDashes = new string('|', 2);
                string bottomHorDashes = new string('-', N);
                for (int i = 0; i < ((N / 2) - 1); i++)
                {
                    Console.WriteLine("{0}{1}{2}", bottomDots, bottomDashes, bottomDots);
                }
                Console.WriteLine(bottomHorDashes);
            }

            if (N >= 12)
            {
                string dots = new string('.', (N / 2 - 1));
                string dashes = new string('|', 2);
                string horDashes = new string('-', N);
                for (int i = 0; i < ((N / 2) - 2); i++)
                {
                    Console.WriteLine("{0}{1}{2}", dots, dashes, dots);
                }
                Console.WriteLine(horDashes);
                Console.WriteLine(horDashes);
            }
        }
    }
}
