using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTasks
{
    class Task7
    {
        public string DuplicateRemover()
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    continue;
                }

                else
                {
                    result = result + input[i];
                }
            }

            result = result + input.Last();

            return result;
        }
    }
}
