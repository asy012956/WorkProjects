using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class BiggestTriple
    {
        public void BiggestTripleSolved()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' '); //124125135
            int newArraySize = (int)(Math.Ceiling((double)(inputArray.Length) / 3));
            int inputArrayIndex = 0;
            int[][] newArray = new int[newArraySize][];
            for (int i = 0; i < newArraySize; i++)
            {
                newArray[i] = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    newArray[i][j] = int.Parse(inputArray[inputArrayIndex]);
                    inputArrayIndex++;
                    if (inputArrayIndex > inputArray.Length - 1)
                    {
                        break;
                    }
                }
            }

            int sum = 0;
            int maxSum = int.MinValue;
            int indexer = 0;

            for (int i = 0; i < newArraySize; i++)
            {
                for (int j = 0; j < newArray[i].Length; j++)
                {
                    sum = sum + newArray[i][j];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    indexer = i;
                }

                sum = 0;
            }

            string output = string.Empty;
            for (int i = 0; i < newArray[indexer].Length; i++)
            {
                if (newArray[indexer][i] != 0)
                {
                    output = output + newArray[indexer][i] + " ";
                }
            }

            Console.WriteLine(output);

        }
    }
}
