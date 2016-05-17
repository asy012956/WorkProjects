using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExercisesSolutions
{
    public class JumpingSums
    {
        public void SolveJumpingSums()
        {
            string input = Console.ReadLine();
            string[] inputToStringArray = input.Split(' ');
            int[] inputToArray = new int[inputToStringArray.Length];
            for (int i = 0; i < inputToArray.Length; i++)
            {
                inputToArray[i] = int.Parse(inputToStringArray[i]);
            }

            int jumps = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxSum = 0;
            int value = 0;
            int extIndex = 0;
            int intIndex = 0;

            for (int i = 0; i < inputToArray.Length; i++)
            {
                for (int j = 0; j < jumps + 1; j++)
                {
                    value = inputToArray[intIndex];
                    sum = sum + value;
                    intIndex = intIndex + value;
                    while (intIndex >= inputToArray.Length)
                    {
                        intIndex = intIndex - inputToArray.Length;
                    }
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                }

                sum = 0;
                extIndex++;
                intIndex = extIndex;
            }

            Console.WriteLine("max sum = " + maxSum);
        }
    }
}
