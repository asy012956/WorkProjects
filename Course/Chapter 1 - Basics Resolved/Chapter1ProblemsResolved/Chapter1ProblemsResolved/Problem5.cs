using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1ProblemsResolved
{
    class Problem5
    {
        public void ReverseSentence()
        {
            string sentence = Console.ReadLine();

            string[] stringArray = sentence.Split(' ');
            Array.Reverse(stringArray);

            string firstLetter = stringArray[0][0].ToString();
            firstLetter = firstLetter.ToUpper();
            string firstWordNew = firstLetter;
            for (int i = 1; i < stringArray[0].Length; i++)
            {
                firstWordNew = firstWordNew + stringArray[0][i];
            }

            stringArray[0] = firstWordNew;

            foreach (string word in stringArray)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine();

            return;
        }
    }
}
