using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter1ProblemsResolved
{
    class Problem3c
    {
        public void PrintMatrixByTriangle()
        {
            StreamReader reader = new StreamReader(@"D:\ASY Projects\Course\Chapter 1 - Basics Resolved\matrixfile.txt");
            string line = reader.ReadLine();
            int leadNumber = int.Parse(line);
            int[,] intArray = new int[leadNumber, leadNumber];
            line = reader.ReadLine();

            int j = 0;

            while (line != null)
            {
                string[] stringArray = line.Split(' ');
                for (int i = 0, row = j; i < stringArray.Length; i++)
                {
                    intArray[row, i] = int.Parse(stringArray[i]);
                }

                j++;
                line = reader.ReadLine();
            }

            reader.Close();

            //-------------------------------
            
            //1. Start from first row, first column. Print the element.

            for (int c = 0; c < leadNumber; c++)
            {
                int column = c;
                for (int r = 0; r < leadNumber; r++)
                {
                    Console.Write(intArray[r,column] + " ");
                    //2. If this is not the most left element, if possible go to the next row one step left and print the element.
                    if (column != 0)
                    {
                        column--;
                    }
                    else
                    {
                        break;
                    }
                }
            }


            //3. Repeat until you find the element, which is the most left one. Then go to step 1 with the next column.


            //1. Start from second row, last element
            int c1 = leadNumber - 1;
            int r1 = 1;
            //2. Check if there's an element one row below and one position to the left; if yes, print it; if not print current element
            for (r1 = 1; r1 < leadNumber; r1++)
            {
                int row = r1;
                for (c1 = leadNumber - 1; c1 > 0; c1--)
                {
                    Console.Write(intArray[row, c1] + " ");
                    if (row < leadNumber - 1)
                    {
                        row++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}
