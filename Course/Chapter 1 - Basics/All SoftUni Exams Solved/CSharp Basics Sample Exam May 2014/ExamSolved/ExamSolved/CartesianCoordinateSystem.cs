using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class CartesianCoordinateSystem
    {
        public int CartesianSolved(double x, double y)
        {
            int result = 0;

            if ((x == 0) && (y == 0))
            {
                result = 0;
            }
            else if ((x > 0) && (y > 0))
            {
                result = 1;
            }
            else if ((x < 0) && (y > 0))
            {
                result = 2;
            }
            else if ((x < 0) && (y < 0))
            {
                result = 3;
            }
            else if ((x > 0) && (y < 0))
            {
                result = 4;
            }
            else if (x == 0 && (y > 0 || y < 0))
            {
                result = 5;
            }
            else if ((x > 0 || x < 0) && y == 0)
            {
                result = 6;
            }

            return result;
        }
    }
}
