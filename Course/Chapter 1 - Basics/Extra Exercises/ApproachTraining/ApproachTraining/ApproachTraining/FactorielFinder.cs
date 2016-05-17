using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachTraining
{
    public class FactorielFinder
    {
        public ulong Factioriel(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            else if (number > 1)
            {
                ulong result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result = result * (ulong)i;
                }

                return result;
            }

            else
            {
                throw new Exception("Number cannot be negative!");
            }
        }


        public ulong Factoriel2(int number)
        {
            if (number <= 1) return 1;
            return (ulong)number * Factoriel2(number - 1);
        }

        public ulong FactorielStack(int number)
        {
            Stack<ulong> stack = new Stack<ulong>();

            stack.Push((ulong)number);
            number--;

            while (number > 1)
            {
                stack.Push((ulong)number);
            }

            ulong result = 0;
            while (stack.Count > 0)
            {
                var calculatedResult = stack.Pop();
                result += calculatedResult;
            }

            return result;
        }

        public ulong Factoriel3(int number)
        {
            ulong[] calculatedFactoriels = new ulong[number];
            calculatedFactoriels[0] = 1;

            for (int i = 1; i < number; i++)
            {
               calculatedFactoriels[i] = ((ulong)i + 1) * calculatedFactoriels[i - 1];
            }

            return calculatedFactoriels[number - 1];
        }





        public int fibonachi(int index)
        {
            if (index == 1)
            {
                return 0;
            }

            if (index == 2 || index == 3)
            {
                return 1;
            }

            return fibonachi(index - 1) + fibonachi(index - 2);
        }
    }
}
