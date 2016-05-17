using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Pairs
    {
        public void PairsSolved()
        {
            //input
            string input = Console.ReadLine();
            string[] inputToArray = input.Split(' ');
            int[] inputToIntegers = new int[inputToArray.Length];
            for (int i = 0; i < inputToArray.Length; i++)
            {
                inputToIntegers[i] = int.Parse(inputToArray[i]);
            }

            //calculations
            List<int> values = new List<int>();
            int result = 0;
            for (int i = 0; i < inputToIntegers.Length; i = i + 2)
            {
                result = inputToIntegers[i] + inputToIntegers[i + 1];
                values.Add(result);
            }

            bool areAllEqual = true;
            int checker = values[0];
            for (int i = 1; i < values.Count; i++)
            {
                if (values[i] != checker)
                {
                    areAllEqual = false;
                }
            }

            //find max difference
            int maxDifference = int.MinValue;
            int currentResult = 0;
            for (int i = 0; i < values.Count - 1; i++)
            {
                currentResult = Math.Abs(values[i + 1] - values[i]);
                if (currentResult > maxDifference)
                {
                    maxDifference = currentResult;
                }
            }

            if (areAllEqual == true)
            {
                Console.WriteLine("Yes, value={0}", result);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDifference);
            }
        }
    }
}
