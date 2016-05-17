using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class OddEvenSum
    {
        public void OddEvenSumSolved(int numberOfElements)
        {
            OddEvenSumAddOn result = new OddEvenSumAddOn();
            //prepare data
            int[] array = new int[numberOfElements * 2];
            for (int i = 0; i < numberOfElements * 2; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //get odd numbers
            for (int i = 0; i < numberOfElements * 2; i = i + 2)
            {
                result.OddSum = result.OddSum + array[i];    
            }

            //get even numbers
            for (int i = 1; i < numberOfElements * 2; i = i + 2)
            {
                result.EvenSum = result.EvenSum + array[i];
            }

            if (result.OddSum == result.EvenSum)
            {
                Console.WriteLine("Yes, sum={0}", result.OddSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", result.OddSum - result.EvenSum);
            }

            return;
        }
    }
}
