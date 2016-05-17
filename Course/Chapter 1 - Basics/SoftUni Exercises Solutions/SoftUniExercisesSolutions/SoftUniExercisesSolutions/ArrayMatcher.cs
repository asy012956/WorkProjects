using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExercisesSolutions
{
    public class ArrayMatcher
    {
        public List<char> SolveArrayMatcher(string input)
        {
            string[] inputArray = input.Split('\\');
            List<char> result = new List<char>();

            if (inputArray[2] == "join")
            {
                result = Join(inputArray);
            }
            else if (inputArray[2] == "right exclude")
            {
                result = RightExclude(inputArray);
            }
            else if (inputArray[2] == "left exclude")
            {
                result = LeftExclude(inputArray);
            }

            return result;
        }

        public List<char> Join(string[] inputArray)
        {
            List<char> output = new List<char>();

            for (int i = 0; i < inputArray[0].Length; i++)
            {
                for (int k = 0; k < inputArray[1].Length; k++)
                {
                    if (inputArray[0][i] == inputArray[1][k])
                    {
                        output.Add(inputArray[0][i]);
                    }
                }
            }

            output.Sort();

            return output;
        }

        public List<char> RightExclude(string[] inputArray)
        {
            List<char> output = new List<char>();
            bool isThere = false;
            for (int i = 0; i < inputArray[0].Length; i++)
            {
                isThere = false;

                for (int k = 0; k < inputArray[1].Length; k++)
                {
                    if (inputArray[0][i] == inputArray[1][k])
                    {
                        isThere = true;
                        break;
                    }
                }

                if (isThere == false)
                {
                    output.Add(inputArray[0][i]);
                }
            }

            output.Sort();

            return output;
        }

        public List<char> LeftExclude(string[] inputArray)
        {
            List<char> output = new List<char>();
            bool isThere2 = false;
            for (int i = 0; i < inputArray[1].Length; i++)
            {
                isThere2 = false;

                for (int k = 0; k < inputArray[0].Length; k++)
                {
                    if (inputArray[1][i] == inputArray[0][k])
                    {
                        isThere2 = true;
                        break;
                    }
                }

                if (isThere2 == false)
                {
                    output.Add(inputArray[1][i]);
                }
            }

            output.Sort();

            return output;
        }
    }
}
