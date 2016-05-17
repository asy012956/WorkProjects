using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTasks
{
    public class Task8
    {
        public int CalculateWorkDays(int margin)
        {
            DateTime now = DateTime.Today.AddDays(margin);
            int dayToday = now.DayOfYear;
            int christmasDay;
            bool leapYear = DateTime.IsLeapYear(now.Year);
            if (leapYear)
            {
                christmasDay = 360;
            }
            else
            {
                christmasDay = 359;
            } 
            int remainingDays = christmasDay - dayToday; 
            double weeks = Math.Floor(remainingDays / 7.0); 
            double days = remainingDays % 7.0;
            double lastWeekDays = days / 7d;
            double lastWorkDays = Math.Floor(lastWeekDays * 4);
            int totalWorkingDays = (int)((weeks * 4) + lastWorkDays);

            return totalWorkingDays;
            //Console.WriteLine("There are {0} working days left.", totalWorkingDays);
        }

        public int CalculateWorkDaysTillChristmas(int margin)
        {
            DateTime today = DateTime.Today.AddDays(margin);
            int workdays = 0;

            while (today < DateTime.Parse("12/25/2016"))
            {
                if (today.DayOfWeek <= DayOfWeek.Thursday && today.DayOfWeek != DayOfWeek.Sunday)
                {
                    workdays++;
                }
                today = today.AddDays(1);
            }

            return workdays;
        }
    }
}
