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
            Triangle runner = new Triangle();
            TriangleResult result = runner.TriangleSolved();
            Console.WriteLine(result.IsTriangle);
            Console.WriteLine(result.AreaOrSide);

            //Pairs runner = new Pairs();
            //runner.PairsSolved();

            //House runner = new House();
            //runner.HouseSolved();
        }
    }
}
