using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter1ProblemsResolved
{
    class Problem3a
    {
        public void PrintMatrixByRow()
        {
            StreamReader reader = new StreamReader(@"D:\ASY Projects\Course\Chapter 1 - Basics Resolved\matrixfile.txt");
            string line;
            string result = string.Empty;
            while ((line = reader.ReadLine()) != null)
            {
                result = result + line + " ";
            }

            result = result.Remove(0, 2);
            Console.WriteLine(result);
        }
    }
}
