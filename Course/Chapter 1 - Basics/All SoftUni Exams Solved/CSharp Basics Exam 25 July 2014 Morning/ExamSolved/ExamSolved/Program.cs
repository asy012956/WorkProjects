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
            //MelonsAndWatermelons runner = new MelonsAndWatermelons();
            //string result = runner.MelonsAndWatermelonsSolved(7, 23560);
            //Console.WriteLine(result);

            //LettersSymbolsNumbers runner = new LettersSymbolsNumbers();
            //List<int> result = runner.LettersSymbolsNumbersSolved(10);
            //foreach(int member in result)
            //{
            //    Console.WriteLine(member);
            //}

            //List<int> result = runner.Letters2Solved("SoftUni – practical software development training + job!");
            //foreach (int member in result)
            //{
            //    Console.WriteLine(member);
            //}


            //int N = int.Parse(Console.ReadLine());
            //string input = string.Empty;
            //for (int i = 0; i < N; i++)
            //{
            //    string userInput = Console.ReadLine();
            //    input = input + userInput;
            //}

            //Letters3 runner = new Letters3();
            //Letters3Attributes result = runner.Letters3Solved(input);
            //Console.WriteLine(result.LettersSum);
            //Console.WriteLine(result.NumbersSum);
            //Console.WriteLine(result.SymbolsSum);

            PandaScotlandFlag runner = new PandaScotlandFlag();
            runner.PandaScotlandFlagSolved(9);
        }
    }
}
