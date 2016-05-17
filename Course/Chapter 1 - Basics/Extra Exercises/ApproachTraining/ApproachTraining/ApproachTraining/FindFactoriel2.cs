using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachTraining
{
    public class FindFactoriel2
    {
        public ulong FactorialCalculator2(ulong number)
        {
            ulong result = 1;

            if (number == 0 || number == 1)
            {
                return 1;
            }

            else
            {
                for (ulong i = number; i > 0; i--)
                {
                    result = result * i;
                }

                return result;
            }
        }
    }
}
