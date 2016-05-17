using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachTraining
{
    public class FindFactoriel3
    {
        public ulong FactorialCalculator3(ulong number)
        {
            ulong sum = 0;
            ulong currentSum = 1;

            if (number == 0 || number == 1)
            {
                return 1;
            }

            else
            {
                for (ulong i = 0; i < number - 1; i++)
                {
                    for (ulong j = 0; j <= i + 1; j++)
                    {
                        sum += currentSum;
                    }
                    currentSum = sum;
                    sum = 0;
                }
            }

            return currentSum;
        }
    }
}
