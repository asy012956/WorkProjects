using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class JoroTheFootballPlayer
    {
        public int JoroTheFootballPlayerSolved(char year, int holidays, int homeWeekends)
        {
            double holidaysPlayed = holidays / 2d;
            int normalWeekends = 52 - homeWeekends;
            double weekendsPlayed = (normalWeekends / 3d) * 2;
            double totalPlayed = (int)Math.Floor(holidaysPlayed + weekendsPlayed + homeWeekends);
            if (year == 't')
            {
                totalPlayed = (int)Math.Floor(totalPlayed + 3);
            }

            return (int)totalPlayed;
        }
    }
}
