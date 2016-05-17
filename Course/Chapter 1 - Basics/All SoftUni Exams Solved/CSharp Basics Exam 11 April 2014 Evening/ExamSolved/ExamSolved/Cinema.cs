using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Cinema
    {
        public string CinemaSolved(string projection, int rows, int columns)
        {
            if (rows < 0 || columns < 0)
            {
                throw new ArgumentException("Rows or columns cannot be negative!");
            }
            else
            {
                int totalSeats = rows * columns;
                CinemaAddOn income = new CinemaAddOn();
                if (projection == "Premiere")
                {
                    income.IncomeCalculation = totalSeats * 12.00m;
                }
                else if (projection == "Normal")
                {
                    income.IncomeCalculation = totalSeats * 7.50m;
                }
                else if (projection == "Discount")
                {
                    income.IncomeCalculation = totalSeats * 5.00m;
                }

                decimal finalIncome = Math.Round(income.IncomeCalculation, 2);
                string output = finalIncome.ToString() + " " + "leva";
                return output;
            }
        }
    }
}
