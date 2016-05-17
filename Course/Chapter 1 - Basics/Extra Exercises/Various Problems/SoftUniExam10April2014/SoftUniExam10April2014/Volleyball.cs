using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExam10April2014
{
    public class Volleyball
    {
        public int CalculateGames(string year, int numberOfHolidays, int numberOfWeekendsAtHome)
        {
            int weekends = 48; //weekends

            double numberOfGames = 0d;
            double holidaysPlayed = (((double)numberOfHolidays * 2) / 3);
            numberOfGames = numberOfGames + holidaysPlayed;
            int normalWeekends = weekends - numberOfWeekendsAtHome;
            double saturdaysPlayed = (((double)normalWeekends * 3) / 4);
            numberOfGames = numberOfGames + saturdaysPlayed + numberOfWeekendsAtHome;
            if (year == "leap")
            {
                numberOfGames = numberOfGames * 1.15f;
            }

            return (int)Math.Floor(numberOfGames);
        }
    }
}
