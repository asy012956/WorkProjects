using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    public class Marto
    {
        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 20);
        }

        public int[] GetNRandomNumbers(int n)
        {
            int[] randomNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                randomNumbers[i] = RandomNumber();
            }

            return randomNumbers;
        }

        public int SumRandomNumbers(int[] randomNumbers)
        {
            int sum = 0;
            foreach (int number in randomNumbers)
            {
                sum += number;
            }

            return sum;
        }

        public int MultiplicationOfRandomNumers(int[] randomNumbers)
        {
            int result = 1;

            foreach (int number in randomNumbers)
            {
                result *= number;
            }

            return result;
        }

        //Main method
        //Marto marto = new Marto();
        //int[] randomNumbers = marto.GetNRandomNumbers(7);
        //int sum = marto.SumRandomNumbers(randomNumbers);

        //Console.WriteLine(sum);

    }
}
