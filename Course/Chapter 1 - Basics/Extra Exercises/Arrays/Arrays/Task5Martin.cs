using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks
{
    public class Task5Martin
    {
        public void Task5()
        {
            string input = Console.ReadLine(); //1a2b3c4d5e
            string numbers = string.Empty;
            string letters = string.Empty;
            for (int i = 0; i < input.Length; i = i + 2)
            {
                numbers = numbers + (Convert.ToString(input[i]));
            }

            Console.WriteLine(numbers);

            for (int i = 1; i < input.Length; i = i + 2)
            {
                letters = letters + (Convert.ToString(input[i]));
            }

            Console.WriteLine(letters);
        }
    }
}
