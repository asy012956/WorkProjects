using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    class Program
    {
        static void Main(string[] args)
        {
            //FitBoxInBox runner = new FitBoxInBox();
            //runner.FitBoxInBoxSolved();

            //SequenceOfKNumbers runner = new SequenceOfKNumbers();
            //string result = runner.SequenceOfKNumbersSolved("3 3 3 3 3 3 3 8 8 2 5 1 7 7 7 4 4 4 4 3 4 4", 4);
            //Console.WriteLine(result);

            Disk runner = new Disk();
            runner.DiskSolved(13, 4);
        }
    }
}
