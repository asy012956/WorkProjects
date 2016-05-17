using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter1ProblemsResolved
{
    class Problem3c2
    {
        public void PrintMatrixByTriangle2()
        {
            MatrixFile reader = new MatrixFile();
            int[,] intArray = reader.ReadMatrixFile();

            int leadNumber = intArray.GetLength(1); //4

            for (int c = leadNumber - 1; c >= 0; c--)
            {
                int column = c;
                for (int r = 0; r < leadNumber; r++)
                {
                    Console.Write(intArray[r, column] + " ");

                    if (column != leadNumber - 1)
                    {
                        column++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //second half

            //Console.WriteLine();

            int col1 = 0;
            int step = 2;
            int rowCounter = 1;

            for (int row1 = 1; row1 < leadNumber; row1++)
            {
                Console.Write(intArray[row1, col1] + " ");
                if (col1 == leadNumber - step)
                {
                    col1 = -1;
                    row1 = rowCounter; 
                    rowCounter++;
                    step++;
                }

                col1++;
            }
            
        }
    }
}
