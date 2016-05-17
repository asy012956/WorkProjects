using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery
{
    public class Hayvan
    {
        public IEnumerable<int> GenerateNumbersThatMeetTheSumCriteria(int expectedSum)
        {
            List<int> numbers = new List<int>(2000000);

            for (int first = 5; first <= 9; first++)
            {
                for (int second = 5; second <= 9; second++)
                {
                    for (int third = 5; third <= 9; third++)
                    {
                        for (int fourth = 5; fourth <= 9; fourth++)
                        {
                            for (int fifth = 5; fifth <= 9; fifth++)
                            {
                                for (int sixth = 5; sixth <= 9; sixth++)
                                {
                                    for (int seventh = 5; seventh <= 9; seventh++)
                                    {
                                        for (int eight = 5; eight <=9; eight++)
                                        {
                                            for (int ninth = 5; ninth <= 9; ninth++)
                                            {
                                                int actualSum = first + second + third + fourth + fifth + sixth + seventh
                                                    + eight + ninth;

                                                if (actualSum == expectedSum)
                                                {
                                                    int number = (int)(first * Math.Pow(10, 8) +
                                                    second * Math.Pow(10, 7) +
                                                    third * Math.Pow(10, 6) +
                                                    fourth * Math.Pow(10, 5) +
                                                    fifth * Math.Pow(10, 4) +
                                                    sixth * Math.Pow(10, 3) +
                                                    seventh * Math.Pow(10, 2) +
                                                    eight * Math.Pow(10, 1) +
                                                    ninth);

                                                    numbers.Add(number);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return numbers;
        }

        public IList<int> RemoveAccordingToDiff(IEnumerable<int> numbers, int diff)
        {
            IList<int> newNumbers = new List<int>(500000);

            foreach (var number in numbers)
            {
                int numberBuff = number;

                int thirdPair = numberBuff % 1000;
                numberBuff = numberBuff / 1000;

                int secondPair = numberBuff % 1000;
                numberBuff = numberBuff / 1000;

                int firstPair = numberBuff;

                int firstSum = secondPair - firstPair;
                int secondSum = thirdPair - secondPair;

                if (firstSum == secondSum && firstSum == diff)
                {
                    newNumbers.Add(number);
                }
            }

            return newNumbers;
        }
    }
}
