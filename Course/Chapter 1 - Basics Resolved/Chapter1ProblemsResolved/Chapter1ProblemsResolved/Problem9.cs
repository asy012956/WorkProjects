using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Chapter1ProblemsResolved
{
    class Problem9
    {
        public void TotalTime()
        {
            StreamReader reader = new StreamReader(@"D:\ASY Projects\Course\Chapter 1 - Basics Resolved\Task9file.txt");
            string line = reader.ReadLine();
            int martosTime = 0;
            int jorosTime = 0;
            double martosHours = 0d;
            double jorosHours = 0d;

            while (line != null)
            {
                string[] lineArray = line.Split(';');
                if (lineArray[0] != "Marto" && lineArray[0] != "Joro")
                {
                    Console.WriteLine("Input invalid");
                    break;
                }

                else if (lineArray[0] == "Marto")
                {
                    StringCalculator marto = new StringCalculator();
                    int result = marto.CalculateStringExpression(lineArray[2]);
                    martosTime = martosTime + result;
                }

                else if (lineArray[0] == "Joro")
                {
                    StringCalculator joro = new StringCalculator();
                    int result = joro.CalculateStringExpression(lineArray[2]);
                    jorosTime = jorosTime + result;
                }

                line = reader.ReadLine();
            }

            reader.Close();

            if (martosTime < 0 || jorosTime < 0)
            {
                Console.WriteLine("Input invalid");
                return;
            }

            if (martosTime > 0)
            {
                martosHours = martosTime / 60d;
                Console.WriteLine("Marto - {0:F2}", martosHours);
            }

            if (jorosTime > 0)
            {
                jorosHours = jorosTime / 60d;
                Console.WriteLine("Joro - {0:F2}", jorosHours);
            }

            return;
        }
    }
}
