using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    public class Task2
    {
        public string FibCalculation(int length)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int thirdNumber = 0;
            string result = String.Empty;
            result += firstNumber + " ";
            result += secondNumber + " ";
            for (int i = 2; i < length; i++)
            {
                thirdNumber = firstNumber + secondNumber;

                string symbol = "";
                if (thirdNumber % 2 == 0)
                {
                    symbol = "-";
                }

                result += symbol + thirdNumber + " ";
                //thirdNumber = Math.Abs(thirdNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;

            }

            return result;
        }



        //Main method
        //        {
        //            string input = Console.ReadLine();
        //        uint length;

        //            while (!uint.TryParse(input, out length))
        //            {
        //                Console.WriteLine("WRONG INPUT!");
        //                input = Console.ReadLine();
        //            }

        //    Task2 run = new Task2();

        //    int[] fibSequence = run.GetFibonachiSequenceUntil(length);
        //            PrintIntArray(fibSequence);
        //}

        //public static void PrintIntArray(int[] array)
        //{
        //    if (array == null)
        //    {
        //        return;
        //    }

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(array[i] + " ");
        //    }
        //}



        public int[] GetFibonachiSequenceUntil(uint index)
        {
            if (index == 0)
            {
                throw new Exception("No way to find the 0-th element!");
            }

            if (index == 1)
            {
                return new int[] { 0 };
            }

            int[] sequence = new int[index];
            sequence[0] = 0;
            sequence[1] = 1;

            for (int i = 2; i < index; i++)
            {
                sequence[i] = sequence[i - 2] + sequence[i - 1];
            }

            for (int i = 0; i < index; i++)
            {
                if (sequence[i] % 2 == 0)
                {
                    sequence[i] *= -1;
                }
            }

            return sequence;
        }

    }
}
