﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter1ProblemsResolved
{
    class Problem3b
    {
        public void PrintMatrixByColumn()
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

            for (int i = 0; i < leadNumber; i++)
            {
                for (int k = 0; k < leadNumber; k++)
                {
                    Console.Write(intArray[k,i] + " ");
                }
            }
        }
    }
}
