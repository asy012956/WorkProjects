using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class HalfSum
    {
        public void HalfSumSolved(int numberOfElements)
        {
            HalfSumAddOn result = new HalfSumAddOn();
            //prepare data
            int[] array = new int[numberOfElements * 2];
            for (int i = 0; i < numberOfElements * 2; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //get first half
            for (int i = 0; i < numberOfElements; i++)
            {
                result.FirstHalfSum = result.FirstHalfSum + array[i];
            }

            //get second half
            for (int i = numberOfElements; i < numberOfElements * 2; i++)
            {
                result.SecondHalfSum = result.SecondHalfSum + array[i];
            }

            if (result.FirstHalfSum == result.SecondHalfSum)
            {
                Console.WriteLine("Yes, sum={0}", result.FirstHalfSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(result.FirstHalfSum - result.SecondHalfSum));
            }

            return;
        }
    }
}
