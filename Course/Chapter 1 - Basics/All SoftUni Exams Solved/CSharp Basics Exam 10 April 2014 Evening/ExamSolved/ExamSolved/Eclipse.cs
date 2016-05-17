using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Eclipse
    {
        public string EclipseSolved(int N)
        {
            string result = string.Empty;

            //create top line
            string emptyTopDot = new string(' ', 1);
            string topStars = new string('*', (N * 2) - 2);
            string emptyTopLine = new string(' ', N - 1);
            result = result + string.Format("{0}{1}{2}{3}{4}{5}{6}", emptyTopDot, topStars,
                emptyTopDot, emptyTopLine, emptyTopDot, topStars, emptyTopDot);
            result = result + Environment.NewLine;

            //create top half
            string topHalfStar = new string('*', 1);
            string topHalfLines = new string('/', (N * 2) - 2);
            string emptySpaces = new string(' ', N - 1);
            for (int i = 0; i < (N - 2) - 2; i++)
            {
                result = result + string.Format("{0}{1}{2}{3}{4}{5}{6}", topHalfStar, topHalfLines,
                    topHalfStar, emptySpaces, topHalfStar, topHalfLines, topHalfStar);
                result = result + Environment.NewLine;
            }

            //create middle line
            string midHalfStar = new string('*', 1);
            string midHalfLines = new string('/', (N * 2) - 2);
            string midLines = new string('-', N - 1);
            result = result + string.Format("{0}{1}{2}{3}{4}{5}{6}", midHalfStar, midHalfLines, midHalfStar,
                midLines, midHalfStar, midHalfLines, midHalfStar);
            result = result + Environment.NewLine;

            //create bottom half
            for (int i = 0; i < (N - 2) - 2; i++)
            {
                result = result + string.Format("{0}{1}{2}{3}{4}{5}{6}", topHalfStar, topHalfLines,
                    topHalfStar, emptySpaces, topHalfStar, topHalfLines, topHalfStar);
                result = result + Environment.NewLine;
            }

            //create bottom line
            result = result + string.Format("{0}{1}{2}{3}{4}{5}{6}", emptyTopDot, topStars,
                emptyTopDot, emptyTopLine, emptyTopDot, topStars, emptyTopDot);
            result = result + Environment.NewLine;

            return result;
        }
    }
}
