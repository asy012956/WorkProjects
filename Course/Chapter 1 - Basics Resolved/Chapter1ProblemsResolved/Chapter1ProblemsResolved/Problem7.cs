using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1ProblemsResolved
{
    class Problem7
    {
        public void AutoCorrectWord()
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    result = result + input[i];
                }
            }

            result = result + input.Last();

            Console.WriteLine(result);

            //string[] resultArray = result.Split(' ');
            //string newResult = string.Empty;
            //for (int i = 0; i < resultArray.Length; i++)
            //{
            //    newResult = newResult + resultArray[i];
            //}

            ////Console.WriteLine(newResult);

            //string finalResult = string.Empty;
            //for (int i = 0; i < newResult.Length - 1; i++)
            //{
            //    if (newResult[i] != newResult[i + 1])
            //    {
            //        finalResult = finalResult + newResult[i];
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

            //finalResult = finalResult + input.Last();

            //Console.WriteLine(finalResult);

            
            //----------------------------------------------------------------------
            
            //string input = Console.ReadLine();
            //string result = string.Empty;
            //string[] inputArray = input.Split(' ');
            //string newInput = string.Empty;
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    newInput = newInput + inputArray[i];
            //}

            //for (int i = 0; i < newInput.Length - 1; i++)
            //{
            //    if (newInput[i] != newInput[i + 1])
            //    {
            //        result = result + newInput[i];
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

            //result = result + newInput.Last();

            //Console.WriteLine(result);
        }
    }
}
