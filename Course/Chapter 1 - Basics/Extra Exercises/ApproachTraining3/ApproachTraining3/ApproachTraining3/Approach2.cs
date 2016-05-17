using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachTraining3
{
    class Approach2
    {
        public void ApproachT2()
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            uint counter = 0;
            bool contains = A.Contains(B);
            if (contains == true)
            {
                counter++;
                Console.WriteLine("{0} , {1}", contains, counter);
            }

            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
