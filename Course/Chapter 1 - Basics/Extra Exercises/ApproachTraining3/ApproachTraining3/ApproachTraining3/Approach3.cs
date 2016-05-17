using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachTraining3
{
    class Approach3
    {
        public void ApproachT3()
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            int counter = 0;
            int k = 0;
            bool isMatch = true;

            for (int i = 0; i < (A.Length - B.Length) + 1; i++)
            {
                int j = i - k;

                if (A[i] != B[j])
                {
                    isMatch = false;
                }

                if (j == (B.Length - 1))
                {
                    i = i - j;
                    k++;

                    if (isMatch == true)
                    {
                        counter++;
                    }

                    isMatch = true;
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
