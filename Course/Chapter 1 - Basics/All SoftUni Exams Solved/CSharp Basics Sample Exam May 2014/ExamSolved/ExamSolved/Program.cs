using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ExamSolved
{
    class Program
    {
        static void Main(string[] args)
        {
            //CartesianCoordinateSystem runner = new CartesianCoordinateSystem();
            //int result = runner.CartesianSolved(12345, -98786543);
            //Console.WriteLine(result);

            //Tribonacci runner = new Tribonacci();
            //BigInteger result = runner.TribonacciSolved(5, -1, 2, 33);
            //Console.WriteLine(result);

            DrawFigure runner = new DrawFigure();
            runner.DrawFigureSolved();
        }
    }
}
