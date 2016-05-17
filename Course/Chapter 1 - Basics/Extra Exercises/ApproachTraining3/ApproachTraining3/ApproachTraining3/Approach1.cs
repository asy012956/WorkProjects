using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachTraining3
{
    class Approach1
    {
        public void ApproachT1()
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            int counter = 0;
            int bLength = B.Length;

            for (int i = 0; i < ((A.Length - B.Length) + 1); i++)
            {
                bool isMatch = true;
                for (int j = 0; j < bLength; j++)
                {
                    if (A[i + j] != B[j])
                    {
                        isMatch = false;
                    }
                }

                if (isMatch == true)
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                Console.WriteLine("Yes, {0}", counter);
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
