using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class House
    {
        public void HouseSolved()
        {
            int N = int.Parse(Console.ReadLine());

            //create top line
            string topStar = new string('*', 1);
            string topDots = new string('.', N / 2);
            Console.WriteLine("{0}{1}{2}", topDots, topStar, topDots);

            //create roof - cycle (N / 2) - 1
            for (int i = 1, j = 1; i <= ((N / 2) - 1); i++, j = j + 2)
            {
                string outRoofDots = new string('.', (N / 2) - i);
                string roofStar = new string('*', 1);
                string intRoofDots = new string('.', j);
                Console.WriteLine("{0}{1}{2}{3}{4}", outRoofDots, roofStar, intRoofDots, roofStar, outRoofDots);
            }

            //create mid line
            string midLine = new string('*', N);
            Console.WriteLine(midLine);

            //create bottom half
            string outBottomDots = new string('.', N / 4);
            string bottomStar = new string('*', 1);
            string intBottomDots = new string('.', N - ((N / 4) + 1) * 2);  
            for (int i = 0; i < N / 3; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", outBottomDots, bottomStar, intBottomDots, bottomStar, outBottomDots);
            }

            //create bottom line
            string bottomLineDots = new string('.', N / 4);
            string bottomStars = new string('*', N - ((N / 4) * 2));
            Console.WriteLine("{0}{1}{2}", bottomLineDots, bottomStars, bottomLineDots);
        }
    }
}
