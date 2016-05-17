using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace ThreeTasks
{
    class Task9
    {
        public void SpentWorkTime()
        {
            StreamReader reader = new StreamReader(@"D:\ASY\Task9.txt");
            string line = reader.ReadLine();

            int timeMarto = 0;
            int timeJoro = 0;
            double martoHours = 0;
            double joroHours = 0;

            while (line != null)
            {
                string[] workArray = line.Split(';');

                if (workArray[0] != "Marto" && workArray[0] != "Joro")
                {
                    Console.WriteLine("Input invalid");
                    break;
                }

                if (workArray[0] == "Marto")
                {
                    DataTable marto = new DataTable();
                    var result = marto.Compute(workArray[2], "");
                    timeMarto = timeMarto + (int)result;
                }

                else if (workArray[0] == "Joro")
                {
                    DataTable joro = new DataTable();
                    var result = joro.Compute(workArray[2], "");
                    timeJoro = timeJoro + (int)result;
                }

                line = reader.ReadLine();

            }

            if ((timeMarto < 0) || (timeJoro < 0))
            {
                Console.WriteLine("Input invalid");
                return;
            }

            if (timeMarto != 0)
            {
                martoHours = timeMarto / 60d;
                Console.WriteLine("Marto - {0:F2}", martoHours);
            }

            if (timeJoro != 0)
            {
                joroHours = timeJoro / 60d;
                Console.WriteLine("Joro - {0:F2}", joroHours);
            }

        }
    }
}

