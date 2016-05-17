using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class TheExplorer
    {
        public string TheExplorerSolved()
        {
            int N = int.Parse(Console.ReadLine());
            string result = string.Empty;

            //create top line
            string topLineDashes = new string('-', N / 2);
            string topLineStar = new string('*', 1);
            result += string.Format("{0}{1}{0}", topLineDashes, topLineStar);
            result += Environment.NewLine;

            //create top half
            for (int i = 1, j = 1; i <= (N / 2) - 1; i++, j = j + 2)
            {
                string topHalfOuterDashes = new string('-', (N / 2) - i);
                string topHalfStar = new string('*', 1);
                string topHalfInnerDashes = new string('-', j);
                result += string.Format("{0}{1}{2}{3}{4}", topHalfOuterDashes, topHalfStar,
                    topHalfInnerDashes, topHalfStar, topHalfOuterDashes);
                result += Environment.NewLine;
            }

            //create mid line
            string midLineStar = new string('*', 1);
            string midLineDashes = new string('-', N - 2);
            result += string.Format("{0}{1}{2}", midLineStar, midLineDashes, midLineStar);
            result += Environment.NewLine;

            //create bottom half
            for (int i = 1, j = N - 4; i <= N / 2 - 1; i++, j = j - 2)
            {
                string bottomHalfOuterDashes = new string('-', i);
                string bottomHalfStar = new string('*', 1);
                string bottomHalfInnerDashes = new string('-', j);
                result += string.Format("{0}{1}{2}{3}{4}", bottomHalfOuterDashes, bottomHalfStar, bottomHalfInnerDashes, bottomHalfStar, bottomHalfOuterDashes);
                result += Environment.NewLine;
            }

            //create bottom line
            string bottomLineDashes = new string('-', N / 2);
            string bottomLineStar = new string('*', 1);
            result += string.Format("{0}{1}{2}", bottomLineDashes, bottomLineStar, bottomLineDashes);
            result += Environment.NewLine;

            return result;
        }
    }
}
