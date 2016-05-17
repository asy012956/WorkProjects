using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class InsideTheBuilding
    {
        public void SolveInsideTheBuilding()
        {
            int h = int.Parse(Console.ReadLine()); //size of building
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] x = new int[5];
            for (int i = 0, j = 0; i < 5; i++, j = j + 2)
            {
                x[i] = numbers[j];
            }

            int[] y = new int[5];
            for (int i = 0, j = 1; i < 5; i++, j = j + 2)
            {
                y[i] = numbers[j];
            }

            for (int i = 0; i < 5; i++)
            {
                if (((x[i] <= h * 3) && (x[i] >= 0)) && ((y[i] <= h) && (y[i] >= 0)))
                {
                    Console.WriteLine("inside");
                }
                else if (((x[i] >= h) && (x[i] <= 2 * h) && (x[i] >= 0) && ((y[i] <= 4 * h) && (y[i] >= 0))))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
}
