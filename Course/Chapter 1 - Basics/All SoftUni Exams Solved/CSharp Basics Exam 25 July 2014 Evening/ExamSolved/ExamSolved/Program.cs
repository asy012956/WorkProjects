using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Program
    {
        static void Main(string[] args)
        {
            Electricity runner = new Electricity();
            int result = runner.ElectricitySolved(2, 76, "9:00");
            Console.WriteLine(result + " Watts");
        }
    }
}
