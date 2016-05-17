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
            //Cinema runner = new Cinema();
            //string result = runner.CinemaSolved("Премиера", 21, 13);
            //Console.WriteLine(result);

            //string input = Console.ReadLine();
            //Illuminati runner = new Illuminati();
            //IlluminatiAddOn result = runner.IlluminatiSolved(input);
            //Console.WriteLine(result.NumberOfVowels);
            //Console.WriteLine(result.SumOfVowels);

            //Milionati mrunner = new Milionati();

            //Console.WriteLine("===========================");

            //result = mrunner.Calculate(input);
            //Console.WriteLine(result.NumberOfVowels);
            //Console.WriteLine(result.SumOfVowels);

            NewHouse runner = new NewHouse();
            runner.NewHouseSolved();
        }
    }
}
