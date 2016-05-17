using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;

namespace ConsoleApplication1
{
    public class Task4
    {
        public void LargestPalindromeProduct()
        {
            int multiplier1 = 999;
            int multiplier2 = 999;
            int[] palindromes = new int[1000000];
            //int number = 0;

            int foundIndex = 0;
            for (; multiplier1 >= 100; multiplier1--)
            {
                multiplier2 = 999;
                for (; multiplier2 >= 100; multiplier2--)
                {
                    int number = multiplier1 * multiplier2;
                    bool isPalindrom = IsPalindrome(number);

                    if (isPalindrom)
                    {
                        palindromes[foundIndex] = number;
                        foundIndex++;
                    }
                }
            }

            int maxPalindrome = palindromes.Max();
            Console.WriteLine(maxPalindrome);
        }

        public bool IsPalindrome(int number)
        {
            string palindrome = number.ToString();
            bool isPalindrome = true;

            for (int i = 0; i < palindrome.Length / 2; i++)
            {
                if (palindrome[i] != palindrome[palindrome.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
