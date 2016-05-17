using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachTraining2
{
    class SymbolCounter2
    {
        public void SymbolCounter()
        {
            string input = Console.ReadLine();
            int[] letters = new int[255];
            for (int i = 0; i < input.Length; i++)
            {
                letters[(int)input[i]]++; 
            }            

            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine("{0} = {1}", (char)(i) ,letters[i]);
            }
        }
    }
}
