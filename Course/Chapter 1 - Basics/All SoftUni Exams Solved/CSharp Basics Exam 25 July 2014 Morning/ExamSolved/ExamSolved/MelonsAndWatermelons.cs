using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class MelonsAndWatermelons
    {
        public string MelonsAndWatermelonsSolved(int startingDay, int numberOfDays)
        {
            if (startingDay == 0 || startingDay < 0)
            {
                throw new ArgumentException("Day of week cannot be zero or negative!");
            }

            if (numberOfDays < 0)
            {
                throw new ArgumentException("The number of days cannot be negative!");
            }

            int totalWatermelonsEaten = 0;
            int totalMelonsEaten = 0;
            string result = string.Empty;
            int moreNeeded = 0;

            for (int i = 0, j = startingDay; i < numberOfDays; i++, j++)
            {
                switch (j)
                {
                    case 1: totalWatermelonsEaten++; break;
                    case 2: totalMelonsEaten = totalMelonsEaten + 2; break;
                    case 3: totalWatermelonsEaten++; totalMelonsEaten++; break;
                    case 4: totalWatermelonsEaten = totalWatermelonsEaten + 2; break;
                    case 5: totalWatermelonsEaten = totalWatermelonsEaten + 2; totalMelonsEaten = totalMelonsEaten + 2; break;
                    case 6: totalWatermelonsEaten++; totalMelonsEaten = totalMelonsEaten + 2; break;
                    case 7: totalWatermelonsEaten = totalWatermelonsEaten + 0; totalMelonsEaten = totalMelonsEaten + 0; break;
                }

                if (j == 7)
                {
                    j = j - 7;
                }
            }

            if (totalWatermelonsEaten > totalMelonsEaten)
            {
                moreNeeded = totalWatermelonsEaten - totalMelonsEaten;
                result = moreNeeded + " more watermelons";
            }
            else if (totalWatermelonsEaten == totalMelonsEaten)
            {
                result = "Equal amount: " + totalWatermelonsEaten;
            }
            else if (totalMelonsEaten > totalWatermelonsEaten)
            {
                moreNeeded = totalMelonsEaten - totalWatermelonsEaten;
                result = moreNeeded + " more melons";
            }

            return result;
        }
    }
}
