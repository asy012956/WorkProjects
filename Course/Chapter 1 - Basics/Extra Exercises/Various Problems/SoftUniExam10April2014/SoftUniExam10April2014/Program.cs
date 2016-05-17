using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExam10April2014
{
    class Program
    {
        static void Main(string[] args)
        {
            //Volleyball runner = new Volleyball();
            //Console.WriteLine(runner.CalculateGames("leap", 0, 30));

            //OddEvenSum runner = new OddEvenSum();
            //Console.WriteLine(runner.AreOddEvenEqual(4));

            //Eclipse runner = new Eclipse();
            //runner.PrintEclipse();

            HayvanNumbers runner = new HayvanNumbers();
            runner.CalculateHayvanNumbers();
        }
    }
}
