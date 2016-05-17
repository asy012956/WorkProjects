using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks
{
    public class Task6Martin
    {
        public void Task6()
        {
            string input = Console.ReadLine(); //Alexander
            string reverse = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse = reverse + Convert.ToString(input[i]);
            }

            Console.WriteLine(reverse);
        }
    }
}
