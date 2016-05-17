using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Problem19
    {
        public void SpiralMatrix(int n)
        {
            if ((n >= 1) && (n <= 20))
            {
                int[,] matrix = new int[n, n];

                int row = 0;
                int col = 0;

                string direction = "right";

                for (int i = 1; i <= n * n; i++)
                {
                    if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                    {
                        direction = "down";
                        col--;
                        row++;

                    }

                    if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                    {
                        direction = "left";
                        row--;
                        col--;
                    }

                    if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                    {
                        direction = "up";
                        col++;
                        row--;
                    }

                    if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                    {
                        direction = "right";
                        row++;
                        col++;
                    }

                    matrix[row, col] = i;

                    if (direction == "right")
                    {
                        col++;
                    }

                    if (direction == "down")
                    {
                        row++;
                    }

                    if (direction == "left")
                    {
                        col--;
                    }

                    if (direction == "up")
                    {
                        row--;
                    }
                }

                for (row = 0; row < n; row++)
                {
                    for (col = 0; col < n; col++)
                    {
                        if (matrix[row, col] < 10)
                        {
                            Console.Write("{0}  ", matrix[row, col]);
                        }

                        else
                        {
                            Console.Write("{0} ", matrix[row, col]);
                        }
                    }

                    Console.WriteLine();
                }
            }

            else
            {
                Console.WriteLine("Wrong input entered!");
            }
        }
    }
}
