using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsGraduation
{
    public class DevisibleSeeker
    {
        /// <summary>
        /// Returns the closest number devisible by the devisor (number is not returned if its devisible)
        /// </summary>
        public int ClosestDevisibleBy(int number, int devisor)
        {
            int before = number - 1;
            int after = number + 1;

            while (true)
            {
                if (IsDevisible(before, devisor) && before != 0)
                {
                    return before;
                }
                
                if (IsDevisible(after, devisor) && after != 0)
                {
                    return after;
                }

                before--;
                after++;
            }
        }

        //returns if the number is devisible by this devisor
        public bool IsDevisible(int number, int devisor)
        {
            return number % devisor == 0;
        }

    }
}
