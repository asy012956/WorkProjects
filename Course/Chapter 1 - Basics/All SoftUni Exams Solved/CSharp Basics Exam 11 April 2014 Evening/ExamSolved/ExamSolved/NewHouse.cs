using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class NewHouse
    {
        public void NewHouseSolved()
        {
            int N = int.Parse(Console.ReadLine());
            //create roof
            for (int i = 0, j = 1; i < N / 2; i++, j = j + 2)
            {
                string roofDashes = new string('-', (N / 2) - i);
                string roofStars = new string('*', j);
                Console.WriteLine("{0}{1}{2}", roofDashes, roofStars, roofDashes);
            }

            //create bottom of roof
            string botRoof = new string('*', N);
            Console.WriteLine(botRoof);

            //create house facade
            string wallTile = new string('|', 1);
            string facadeStars = new string('*', N - 2);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("{0}{1}{2}", wallTile, facadeStars, wallTile);
            }
        }
    }
}
