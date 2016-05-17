using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Georgi
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x1 = 0f;
            double x2 = 0f;
            QuadraticEquation runner = new QuadraticEquation();
            runner.SolveQuadraticEquation(a, b, c, out x1, out x2);
        }
    }
}
