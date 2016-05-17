using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class OddEvenElements
    {
        public void OddEvenElementsSolved()
        {
            //Input-------------------------------------------
            string input = Console.ReadLine();
            string[] inputToArray = input.Split(' ');
            List<double> oddElements = new List<double>();
            List<double> evenElements = new List<double>();
            for (int i = 0; i < inputToArray.Length; i = i + 2)
            {
                oddElements.Add(double.Parse(inputToArray[i]));
            }

            for (int i = 1; i < inputToArray.Length; i = i + 2)
            {
                evenElements.Add(double.Parse(inputToArray[i]));
            }

            //Odd Elements -----------------------------------
            double oddElementsSum = 0;
            foreach (double member in oddElements)
            {
                oddElementsSum = oddElementsSum + member;
            }

            double oddElementsMin = double.MaxValue;
            foreach (double member in oddElements)
            {
                if (member < oddElementsMin)
                {
                    oddElementsMin = member;
                }
            }

            double oddElementsMax = double.MinValue;
            foreach (double member in oddElements)
            {
                if (member > oddElementsMax)
                {
                    oddElementsMax = member;
                }
            }

            //Even Elements ------------------------------------
            double evenElementsSum = 0;
            foreach (double member in evenElements)
            {
                evenElementsSum = evenElementsSum + member;
            }

            double evenElementsMin = double.MaxValue;
            foreach (double member in evenElements)
            {
                if (member < evenElementsMin)
                {
                    evenElementsMin = member;
                }
            }

            double evenElementsMax = double.MinValue;
            foreach (double member in evenElements)
            {
                if (member > evenElementsMax)
                {
                    evenElementsMax = member;
                }
            }

            //Output----------------------------------
            if (oddElements.Count == 0 && evenElements.Count > 0)
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum={0}, EvenMin={1}, EvenMax={2}",
                evenElementsSum, evenElementsMin, evenElementsMax);
            }
            else if (oddElements.Count > 0 && evenElements.Count == 0)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                oddElementsSum, oddElementsMin, oddElementsMax);
            }
            else if (oddElements.Count > 0 && evenElements.Count > 0)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                    oddElementsSum, oddElementsMin, oddElementsMax, evenElementsSum, evenElementsMin, evenElementsMax);
            }
        }
    }
}
