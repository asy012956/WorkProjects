using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTasks
{
    public class Task6
    {
        public bool IsItPalindrome(string word)
        {
            if (word == null)
            {
                throw new NullReferenceException("the Word that we check if it is palyndrome is NULL!");
            }

            int divider = word.Length / 2;
            bool isPalindrome = true;

            for (int i = 0; i < divider; i++)
            {
                if (word[i] != word[word.Length - 1 - i]) 
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
