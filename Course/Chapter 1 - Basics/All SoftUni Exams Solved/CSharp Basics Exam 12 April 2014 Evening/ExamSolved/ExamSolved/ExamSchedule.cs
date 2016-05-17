using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class ExamSchedule
    {
        public void ExamScheduleSolved()
        {
            int startHour = int.Parse(Console.ReadLine()); 
            int startMinutes = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            int durHours = int.Parse(Console.ReadLine());
            int durMinutes = int.Parse(Console.ReadLine());

            int endHours = startHour + durHours;
            int endMinutes = startMinutes + durMinutes;
            if (endMinutes >= 60)
            {
                int addHours = endMinutes / 60;
                endHours = endHours + addHours;
                endMinutes = endMinutes - (addHours * 60);
            }

            if (endHours > 12 && endHours <= 24)
            {
                endHours = endHours - 12;
                if (partOfDay == "AM")
                {
                    partOfDay = "PM";
                }
                else
                {
                    partOfDay = "AM";
                }
            }
            else if (endHours > 24)
            {
                int days = durHours / 24;
                int addHours = durHours - (days * 24);
                endHours = startHour + addHours;
                if (endHours >= 12)
                {
                    int days1 = endHours / 12;
                    endHours = endHours - (days1 * 12);
                    if (partOfDay == "AM")
                    {
                        partOfDay = "PM";
                    }
                    else
                    {
                        partOfDay = "AM";
                    }
                }
            }
            else if (endHours == 12)
            {
                if (partOfDay == "AM")
                {
                    partOfDay = "PM";
                }
                else
                {
                    partOfDay = "AM";
                }
            }

            if (endHours < 10 && endMinutes < 10)
            {
                Console.WriteLine("0" + endHours + ":" + "0" + endMinutes + ":" + partOfDay);
            }
            else if (endHours < 10 && endMinutes >= 10)
            {
                Console.WriteLine("0" + endHours + ":" + endMinutes + ":" + partOfDay);
            }
            else if (endHours >= 10 && endMinutes < 10)
            {
                Console.WriteLine(endHours + ":" + "0" + endMinutes + ":" + partOfDay);
            }
            else if (endHours >= 10 && endMinutes >= 10)
            {
                Console.WriteLine(endHours + ":" + endMinutes + ":" + partOfDay);
            }
        }
    }
}
