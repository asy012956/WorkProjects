using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class InputExercises
    {
        public int MultiplyExercise(int a, int b) // 3, 9
        {
            int result = 0;
            for (int i = 1; i <= b; i++)
            {
                result = result + a;
            }
            return result;
        }

        public int DivideExercise(int a, int b) // 12, 5
        {
            int counter = 0;
            int c = b;
            while (c < a)
            {
                counter++;
                a = a - c;
            }

            return counter;
        }

        public string DivideRealExercise(int a, int b) //5, 4
        {
            int counter1 = 0;
            int counter2 = 0, counter3 = 0;
            int remainder = 0;
            while (b < a)
            {
                counter1++;
                a = a - b;
                remainder = a; //1
            }

            int newRemainder = remainder * 10; //10

            while (newRemainder >= b)
            {
                counter2++;
                newRemainder = newRemainder - b; //2
            }

            int newRemainder2 = newRemainder * 10; //20

            while (newRemainder2 >= b)
            {
                counter3++;
                newRemainder2 = newRemainder2 - b; //5
            }

            string result = counter1 + "." + counter2 + (counter3.ToString());
            return result;
        }


        public string DivideRealNumbers(int a, int b, int precision) //15, 4, 4
        {
            string result = string.Empty;

            for (int i = 0; i < precision; i++)
            {
                int counter = 0;

                while (b <= a)
                {
                    counter++;
                    a = a - b;
                }

                result = result + counter;
                if (i == 0)
                {
                    result = result + ".";
                }
                a = a * 10;
            }



            return result;

            //while (b < a)
            //{
            //    counter1++;
            //    a = a - b;
            //    remainder = a; //1
            //}

            //int newRemainder = remainder * 10; //10

            //while (newRemainder >= b)
            //{
            //    counter2++;
            //    newRemainder = newRemainder - b; //2
            //}

            //int newRemainder2 = newRemainder * 10; //20

            //while (newRemainder2 >= b)
            //{
            //    counter3++;
            //    newRemainder2 = newRemainder2 - b; //5
            //}

            //string result = counter1 + "." + counter2 + (counter3.ToString());
            //return result;
        }
    }
}
