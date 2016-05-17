using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Disk
    {
        public void DiskSolved(int N, int R)
        {
            int diskCenterRow = N / 2;
            int diskCenterColumn = N / 2;

            for (int row = 0; row < N; row++)
            {
                for (int column = 0; column < N; column++)
                {
                    double dotXCoor = column - diskCenterColumn;
                    double dotYCoor = row - diskCenterRow;
                    double distanceToCenter = Math.Sqrt(Math.Pow(dotXCoor, 2) + Math.Pow(dotYCoor, 2));
                    
                    if (distanceToCenter <= R)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
