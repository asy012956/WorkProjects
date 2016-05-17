using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Problem10
    {
        public void OddAndEvenProduct()
        {
            //You are given n integers (given in a single line, separated by a space).
            //Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
            //Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

            //Main Method
            //Problem10 problem10Runner = new Problem10();
            //problem10Runner.OddAndEvenProduct();


            string[] numbers = Console.ReadLine().Split(' ');  

            int productOdd = 1;
            int productEven = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    productOdd = productOdd * Convert.ToInt32(numbers[i]);
                }

                else 
                {
                    productEven = productEven * Convert.ToInt32(numbers[i]);
                }
            }

            if (productEven == productOdd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + productOdd);
            }

            else 
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", productOdd);
                Console.WriteLine("even_product = {0}", productEven);
            }

        }
    }
}
