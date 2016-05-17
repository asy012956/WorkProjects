using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //ulong number = ulong.Parse(Console.ReadLine());
            //FindFactoriel1 runner = new FindFactoriel1();
            //ulong finalResult = runner.FactorielCalculator(number);
            //Console.WriteLine(finalResult);

            //ulong number = ulong.Parse(Console.ReadLine());
            //FindFactoriel2 runner = new FindFactoriel2();
            //ulong result = runner.FactorialCalculator2(number);
            //Console.WriteLine(result);

            ulong number = ulong.Parse(Console.ReadLine());
            FindFactoriel3 runner = new FindFactoriel3();
            ulong result = runner.FactorialCalculator3(number);
            Console.WriteLine(result);
        }
    }
}
