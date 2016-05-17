using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachTraining
{
    public class FindFactoriel1
    {
        public ulong FactorielCalculator(ulong number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            else if (number > 1)
            {
                ulong result = 1;
                for (ulong i = 1; i <= number; i++)
                {
                    result = result * i;
                }

                return result;
            }

            else 
            {
                throw new Exception("Number cannot be negative!");
            }
        }
    }
}
