using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Volleyball
    {
        public int VolleyballSolved(string year, int holidays, int homeWeekends)
        {
            double playHolidays = (holidays * 2) / 3d;
            int normalWeekends = 48 - homeWeekends;
            double playWeekends = (normalWeekends * 3) / 4d;
            double totalPlayed = playHolidays + playWeekends + homeWeekends;

            if (year == "leap")
            {
                totalPlayed = Math.Floor(totalPlayed * 1.15d);
            }

            return (int)Math.Floor(totalPlayed);
        }
    }
}
