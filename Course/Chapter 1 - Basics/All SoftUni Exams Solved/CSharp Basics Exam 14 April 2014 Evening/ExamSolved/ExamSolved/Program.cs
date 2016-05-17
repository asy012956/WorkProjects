using ExamSolved.OOP_Ninjitsu;
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
            //InsideTheBuilding runner = new InsideTheBuilding();
            //runner.SolveInsideTheBuilding();

            //StudentCables runner = new StudentCables();
            //runner.SolveStudentCables();

            ProgrammerDNA runner = new ProgrammerDNA();
            runner.ProgrammerDNASolved();

            //Marto Solution
            //int strainSize = int.Parse(Console.ReadLine()); 
            //int sequenceLength = int.Parse(Console.ReadLine()); 
            //char seed = Convert.ToChar(Console.ReadLine());

            //DNA sequencer = new DNA(seed, strainSize);
            //string result = sequencer.GetDNASequence(sequenceLength);
            //Console.WriteLine(result);



        }
    }
}
