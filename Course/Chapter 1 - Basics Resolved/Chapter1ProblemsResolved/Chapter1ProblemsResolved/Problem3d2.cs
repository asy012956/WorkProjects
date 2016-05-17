using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1ProblemsResolved
{
    public class Problem3d2
    {
        public void PrintMatrixBySpiral2()
        {
            MatrixFile reader = new MatrixFile();
            int[,] intArray = reader.ReadMatrixFile();

            int size = intArray.GetLength(1);

            int cycles = 0;
            if (size % 2 == 0)
            {
                cycles = size / 2;
            }
            else
            {
                cycles = (size / 2) + 1;
            }

            for (int i = 0; i < cycles; i++)
            {
                for (int k = i; k < size - i; k++)
                {
                    Console.Write(intArray[k, i] + " ");
                }

                for (int m = i + 1; m < size - i; m++)
                {
                    Console.Write(intArray[size - i - 1, m] + " ");
                }

                for (int n = size - 1 - 1 - i; n >= i; n--)
                {
                    Console.Write(intArray[n, size - 1 - i] + " ");
                }

                for (int p = size - 1 - 1 - i; p >= i + 1; p--)
                {
                    Console.Write(intArray[i, p] + " ");
                }
            }
        }
    }
}
