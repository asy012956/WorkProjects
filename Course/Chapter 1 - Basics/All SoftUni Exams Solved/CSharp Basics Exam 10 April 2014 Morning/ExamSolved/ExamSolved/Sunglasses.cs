using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Sunglasses
    {
        public void SunglassesSolved()
        {
            int N = int.Parse(Console.ReadLine());

            //create top line
            string topStars = new string('*', N * 2);
            string emptyTopLine = new string(' ', N);
            Console.WriteLine("{0}{1}{2}", topStars,
                emptyTopLine, topStars);

            //create top half
            string topHalfStar = new string('*', 1);
            string topHalfLines = new string('/', (N * 2) - 2);
            string emptySpaces = new string(' ', N);
            for (int i = 0; i < (N - 2) - 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", topHalfStar, topHalfLines,
                    topHalfStar, emptySpaces, topHalfStar, topHalfLines, topHalfStar);
            }

            //create middle line
            string midHalfStar = new string('*', 1);
            string midHalfLines = new string('/', (N * 2) - 2);
            string midLines = new string('|', N);
            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", midHalfStar, midHalfLines, midHalfStar,
                midLines, midHalfStar, midHalfLines, midHalfStar);

            //create bottom half
            for (int i = 0; i < (N - 2) - 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", topHalfStar, topHalfLines,
                    topHalfStar, emptySpaces, topHalfStar, topHalfLines, topHalfStar);
            }

            //create bottom line
            Console.WriteLine("{0}{1}{2}", topStars,
                emptyTopLine, topStars);
        }
    }
}
