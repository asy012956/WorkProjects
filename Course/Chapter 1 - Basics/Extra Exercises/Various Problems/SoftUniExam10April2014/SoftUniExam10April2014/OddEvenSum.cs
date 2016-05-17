using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExam10April2014
{
    public class OddEvenSum
    {
        public int AreOddEvenEqual(int n)
        {
            //int n = ushort.Parse(Console.ReadLine());
            int counter = 2 * n;
            int[] array = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < counter; i = i + 2)
            {
                sumOdd = sumOdd + array[i];
            }

            for(int i = 1; i < counter; i = i + 2)
            {
                sumEven = sumEven + array[i];
            }

            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes, sum={0}", sumOdd);
                return sumOdd;
            }
            else
            {
                int difference = sumOdd - sumEven;
                if (difference < 0)
                {
                    difference = difference * (-1);
                }

                Console.WriteLine("No, diff={0}", difference);
                return difference;
            }
        }
    }
}
