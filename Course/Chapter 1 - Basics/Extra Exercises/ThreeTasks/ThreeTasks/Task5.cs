using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTasks
{
    public class Task5
    {
        public string RearrangeWords(string word)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string result = string.Empty;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result = result + words[i] + " ";
            }

                return result;
        }
    }
}
