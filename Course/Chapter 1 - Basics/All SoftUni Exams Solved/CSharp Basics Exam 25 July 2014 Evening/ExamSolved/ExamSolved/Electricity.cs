using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Electricity
    {
        public int ElectricitySolved(int floors, int flats, string time)
        {
            double lampConsumption = 100.53;
            double computerConsumption = 125.90;
            double totalConsumption = 0;

            DateTime timeNow = DateTime.Parse(time);

            if (timeNow.Hour >= 0 && timeNow.Hour < 9)
            {
                totalConsumption = ((8 * computerConsumption) + 100.53) * flats * floors;
            }
            else if (timeNow.Hour >= 9 && timeNow.Hour < 14)
            {
                totalConsumption = 0;
            }
            else if (timeNow.Hour >= 14 && timeNow.Hour < 19)
            {
                totalConsumption = ((2 * lampConsumption) + (2 * computerConsumption)) * flats * floors;
            }
            else if (timeNow.Hour >= 19 && timeNow.Hour < 24)
            {
                totalConsumption = ((7 * lampConsumption) + (6 * computerConsumption)) * flats * floors;
            }

            int consumption = (int)Math.Floor(totalConsumption);

            return consumption;
        }
    }
}
