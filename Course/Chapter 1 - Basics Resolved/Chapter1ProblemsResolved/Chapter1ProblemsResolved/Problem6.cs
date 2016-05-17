using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1ProblemsResolved
{
    class Problem6
    {
        public void IsPalindrome()
        {
            string input = Console.ReadLine();
            if (input == null)
            {
                throw new Exception("The word you entered is NULL!");
            }

            bool isPalindrome = true;
            int divider = input.Length / 2;

            for (int i = 0; i < divider; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
