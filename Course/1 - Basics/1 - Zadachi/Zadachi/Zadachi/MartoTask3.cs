using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadachi
{
    public class MartoTask3
    {
        public string GetALLArrayContentFromFile(out int size)
        {
            StreamReader reader = new StreamReader(@"D:\ASY\Task3matrix.txt");
            string line = reader.ReadLine();

            size = int.Parse(line);

            string endResult = string.Empty;

            while (line != null)
            {
                line = reader.ReadLine();
                endResult = endResult + line + " ";
            }

            reader.Close();

            return endResult;
        }

        // Read the matrix file
        public string GetArrayContentFromFile()
        {
            StreamReader reader = new StreamReader(@"D:\ASY\Task3matrix.txt");
            string line = reader.ReadLine();
            string endResult = string.Empty;
            while (line != null)
            {
                line = reader.ReadLine();
                endResult = endResult + line + " ";
            }
            reader.Close();

            return endResult;
        }

        public int[,] ConvertMatrixToIntArray2()
        {
            int size;
            string numbersLine = GetALLArrayContentFromFile(out size);

            int[,] intArray = new int[size, size];

            string[] textAsNumbers = numbersLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int row = 0;
            int col = 0;

            for (int i = 0; i < textAsNumbers.Length; i++)
            {
                int parsedNumber = int.Parse(textAsNumbers[i]); //1
                intArray[row, col] = parsedNumber;
                col++;
                if (col == 4)
                {
                    row++;
                    col = 0;
                }
            }

            //int index = 0;
            //for (int row2 = 0; row2 < size; row2++)
            //{
            //    for (int col2 = 0; col2 < size; col2++)
            //    {
            //        int parsedNumber = int.Parse(textAsNumbers[index]); //1
            //        intArray[row2, col2] = parsedNumber;
            //        index++;
            //    }
            //}

            return intArray;
        }

        public int[,] ConvertMatrixToIntArray()
        {
            StreamReader reader = new StreamReader(@"D:\ASY\Task3matrix.txt");
            string line = reader.ReadLine();
            int size = int.Parse(line);
            int[,] intArray = new int[size, size];

            line = reader.ReadLine();

            int row = 0;

            while (line != null)
            {
                string[] stringNumbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for(int j = 0; j < stringNumbers.Length; j++)
                {
                    int number = int.Parse(stringNumbers[j]);
                    intArray[row, j] = number;
                }

                row++;
                line = reader.ReadLine();
            }

            reader.Close();
            return intArray;
        }

        //public string ByColumn(int[,] intArray)
        //{
        //    string result = string.Empty;
        //    for (int col = 0; col < intArray.GetLength(1); col++)
        //    {
        //        for (int row = 0; row < intArray.GetLength(0); row++)
        //        {
        //            result = result + intArray[row, col] + " ";
        //        }
        //    }

        //    return result;
        //}

    }
}
