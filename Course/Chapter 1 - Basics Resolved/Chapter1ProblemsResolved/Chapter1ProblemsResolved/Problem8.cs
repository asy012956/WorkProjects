using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1ProblemsResolved
{
    class Problem8
    {
        public void DaysUntilChristmas()
        {
            DateTime today = DateTime.Today; //02/29/2016
            int workdays = 0;
            while (today < DateTime.Parse("12/25/2016"))
            {
                if ((today.DayOfWeek == DayOfWeek.Monday) || (today.DayOfWeek == DayOfWeek.Tuesday) || (today.DayOfWeek == DayOfWeek.Wednesday) || (today.DayOfWeek == DayOfWeek.Thursday))
                {
                    workdays++;
                }
                today = today.AddDays(1);
            }

            Console.WriteLine(workdays);

            //int year = today.Year;
            //int christmasDay;
            //int dayToday = today.DayOfYear;
            //bool isLeapYear = DateTime.IsLeapYear(year);

            //if (isLeapYear == true)
            //{
            //    christmasDay = 360;
            //}

            //else
            //{
            //    christmasDay = 359;
            //}


            //int daysTillChristmas = christmasDay - dayToday;


        }
    }
}
