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
            //Volleyball runner = new Volleyball();
            //Console.WriteLine(runner.VolleyballSolved("normal", 6, 13));

            //OddEvenSum runner = new OddEvenSum();
            //runner.OddEvenSumSolved(4);

            Eclipse runner = new Eclipse();
            string result = runner.EclipseSolved(9);
            Console.WriteLine(result);
        }
    }
}
