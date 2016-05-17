using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlluminatiLock
{
    class IlluminatiLock
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int height = N + 1;
            int width = N * 3;

            //create top line
            string dots1 = new string('.', N);
            string numberSign1 = new string('#', N);
            Console.WriteLine("{0}{1}{0}", dots1, numberSign1); 

            //internal row
            string numberSign2 = "#";
            string dots2 = new string('.', N-2);
            string internalRow = numberSign2 + dots2 + numberSign2; //internal row!!!

            //top half
            for (int row = 0; row < (height - 2) / 2; row++)
            {
                string dots3 = new string('.', N - 2 - (row * 2));
                string numberSign3 = "##";
                string dots4 = new string('.', row * 2);
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", dots3, numberSign3, dots4, internalRow, dots4, numberSign3, dots3);
            }

            //bottom half
            for (int row = 0; row < (height - 2) / 2; row++) 
            {
                string dots5 = new string('.', (2 * row) + 1);
                string numberSign4 = "##";
                string dots6 = new string('.', (N - 3) - (row * 2));
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", dots5, numberSign4, dots6, internalRow, dots6, numberSign4, dots5);
            }

            //bottom line
            Console.WriteLine("{0}{1}{0}", dots1, numberSign1);
        }
    }
}
