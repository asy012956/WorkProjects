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
            //WorkHours runner = new WorkHours();
            //WorkHoursAddOn result = runner.WorkHoursSolved(21, 10, 10);
            //Console.WriteLine(result.CanFinishProject);
            //Console.WriteLine(result.Difference);

            //SumOfElements runner = new SumOfElements();
            //SumOfElementsAddOn result = runner.SumOfElementsSolved("5 5 1");
            //Console.WriteLine("Yes, sum={0}", result.Sum);

            TheExplorer runner = new TheExplorer();
            runner.TheExplorerSolved();
        }
    }
}
