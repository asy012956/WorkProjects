using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1ProblemsResolved
{
    public class StringCalculator
    {
        public void Execute()
        {
            string input = Console.ReadLine();
            int result = this.CalculateStringExpression(input);

            Console.WriteLine(result);
        }

        /// <summary>
        /// This method accepts a string mathematical expression containing only Add and Subtract 
        /// operations and calculates the result of this expression
        /// </summary>
        /// <param name="expression">The string expression containing only + and - operators</param>
        /// <returns>Calculated result</returns>
        public int CalculateStringExpression(string expression)
        {
            string[] numbers = expression.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
            List<char> signs = new List<char>();
            for (int i = 0; i < expression.Length - 1; i++)
            {
                if ((expression[i] == '+') || (expression[i] == '-'))
                {
                    signs.Add(expression[i]);
                }
            }

            int result = int.Parse(numbers[0]);

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (signs[i] == '+')
                {
                    result = result + int.Parse(numbers[i + 1]);
                }
                else
                {
                    result = result - int.Parse(numbers[i + 1]);
                }
            }

            return result;
        }
    }
}
