using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class StudentCables
    {
        public void SolveStudentCables()
        {
            int n = int.Parse(Console.ReadLine()); //number of cables
            string[] cables = new string[2 * n];
            for (int i = 0; i < 2 * n; i++)
            {
                cables[i] = Console.ReadLine();
            }

            int totalCableLength = 0;
            int currentCableLength = 0;
            int joints = 0;
            for (int i = 0; i < cables.Length; i = i + 2)
            {
                if (cables[i + 1] == "meters")
                {
                    currentCableLength = int.Parse(cables[i]) * 100;
                    totalCableLength = totalCableLength + currentCableLength;
                    joints++;
                }
                else
                {
                    if (int.Parse(cables[i]) >= 20)
                    {
                        currentCableLength = int.Parse(cables[i]);
                        totalCableLength = totalCableLength + currentCableLength;
                        joints++;
                    }
                }
            }

            int finalTotalCableLength = totalCableLength - 3 * (joints - 1);

            int cableLength = 504;
            double cablesMade = (double)finalTotalCableLength / cableLength;
            int cablesMadeFinal = (int)Math.Floor(cablesMade);
            int remainingCable = finalTotalCableLength - (cablesMadeFinal * cableLength);

            Console.WriteLine(cablesMadeFinal);
            Console.WriteLine(remainingCable);
        }
    }
}
