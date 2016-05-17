using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExam10April2014
{
    public class HayvanNumbers
    {
        public void CalculateHayvanNumbers()
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());

            List<int> hayvanNumbers = new List<int>();

            for (int i = 555555555; i <= 999999999; i++)
            {
                int sumDigits = 0;
                int workInteger = i;
                while (workInteger > 0)
                {
                    int digit = workInteger % 10;
                    if (digit < 5 || digit > 9)
                    {
                        break;
                    }
                    else
                    {
                        sumDigits = sumDigits + digit;
                        workInteger = workInteger / 10;
                    }
                }

                if (sumDigits == sum)
                {
                    hayvanNumbers.Add(i);
                }
            }

            //for (int i = 0; i < hayvanNumbers.Count; i++)
            //{
            //    Console.WriteLine(hayvanNumbers[i]);
            //}

            //int remainder1 = sum % 1000;
            //Console.WriteLine(remainder1);
            //sum = sum / 1000;
            //Console.WriteLine(sum);
            //int remainder2 = sum % 1000;
            //Console.WriteLine(remainder2);
            //sum = sum / 1000;
            //Console.WriteLine(sum);


            //FINISH AT A LATER TIME!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }
    }
}
