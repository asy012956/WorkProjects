using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Problem13
    {
        public void BinaryToDecimal()
        {

            //Main method
            //Problem13 problem13Runner = new Problem13();
            //problem13Runner.BinaryToDecimal();

            string binary = Console.ReadLine(); //1110 0111 0101
            double workResult = 0;
            double finalResult = 0;
            double power = binary.Length - 1;

            for (int i = 0; i < binary.Length; i++)
            {
                char ch = binary[i];
                int convertCh = Convert.ToInt32(ch.ToString());
                if (convertCh == 1)
                {
                    workResult = convertCh * (Math.Pow(2, power));
                    finalResult = finalResult + workResult;
                }

                power--;
            }

            Console.WriteLine((long)finalResult);
            
        }

    }
}
