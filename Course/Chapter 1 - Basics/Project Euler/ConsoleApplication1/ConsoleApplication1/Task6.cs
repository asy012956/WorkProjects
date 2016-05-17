using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Task6
    {
        public void SumSquareDifference()
        {
            int sumOfSquares = 0;
            double squareOfSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                squareOfSum = squareOfSum + i;
            }

            squareOfSum = (int)Math.Pow(squareOfSum, 2);

            for (double i = 1; i <= 100; i++)
            {
                sumOfSquares = sumOfSquares + (int)Math.Pow(i, 2);
            }

            int result = ((int)squareOfSum) - sumOfSquares;
            Console.WriteLine(result);
        }
    }
}
