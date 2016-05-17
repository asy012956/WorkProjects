using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterHerbalist
{
    class MasterHerbalist
    {
        static void Main(string[] args)
        {
            int dailyExpenses = int.Parse(Console.ReadLine()); // Penka's daily expenses
            string dailyActivities = Console.ReadLine(); //5 MMZHQQQQ 37
            int days = 0;
            int hours = 0; //hours spent gathering herbs
            int numberOfHerbsCollected = 0; // number of herbs gathered
            int totalMoneyMade = 0; // total money made
            double averageMoneyMade = 0d;


            while (dailyActivities != "Season Over")
            {
                char[] separator = new char[] { ' ' };
                string[] dailyActivitiesSplit = dailyActivities.Split(separator);
                hours = Convert.ToInt32(dailyActivitiesSplit[0]);
                string dailyActivitiesToCover = dailyActivitiesSplit[1];
                //if (hours > dailyActivitiesToCover.Length)
                //{
                //    dailyActivitiesToCover = dailyActivitiesToCover + dailyActivitiesToCover + dailyActivitiesToCover + dailyActivitiesToCover + dailyActivitiesToCover + dailyActivitiesToCover + dailyActivitiesToCover + dailyActivitiesToCover + dailyActivitiesToCover;
                //}
                while (hours>dailyActivitiesToCover.Length)
                {
                    dailyActivitiesToCover += dailyActivitiesToCover;
                }
                for (int i = 0; i < hours; i++)
                {
                    char letter = dailyActivitiesToCover[i];
                    if (letter == 'H')
                    {
                        numberOfHerbsCollected++;
                    }
                }

                totalMoneyMade = totalMoneyMade + (numberOfHerbsCollected * Convert.ToInt32(dailyActivitiesSplit[2]));
                days++;
                numberOfHerbsCollected = 0;

                dailyActivities = Console.ReadLine();
            }

            averageMoneyMade = totalMoneyMade / (double)days;

            if (averageMoneyMade >= dailyExpenses)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:F2}.", averageMoneyMade - dailyExpenses);
            }

            else if (averageMoneyMade < dailyExpenses)
            {
                Console.WriteLine("We are in the red. Money needed: {0}.", (double)(dailyExpenses * days) - (averageMoneyMade * days));
            }
        }
    }
}

