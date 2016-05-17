using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class WorkHours
    {
        public WorkHoursAddOn WorkHoursSolved(int h, int d, int p)
        {
            WorkHoursAddOn result = new WorkHoursAddOn();
            result.CanFinishProject = string.Empty;
            result.Difference = string.Empty;
            double realWorkDays = d * 0.9d;
            double percentage = (double)p / 100;
            double totalWorkHours = realWorkDays * 12;
            double realWorkHours = Math.Floor(totalWorkHours * percentage);
            if (realWorkHours >= h)
            {
                result.CanFinishProject = "Yes";
                result.Difference = (((int)realWorkHours) - h).ToString();
            }
            else
            {
                result.CanFinishProject = "No";
                result.Difference = (((int)realWorkHours) - h).ToString();
            }

            return result;
        }
    }
}
