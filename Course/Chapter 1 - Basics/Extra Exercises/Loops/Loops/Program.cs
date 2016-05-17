using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Problem19 problem19Runner = new Problem19();
            problem19Runner.SpiralMatrix(n);
        }
    }
}
