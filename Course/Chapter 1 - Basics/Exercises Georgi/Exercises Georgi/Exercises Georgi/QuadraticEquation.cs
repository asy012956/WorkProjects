using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Georgi
{
    public class QuadraticEquation
    {
        public bool SolveQuadraticEquation(double a, double b, double c, out double x1, out double x2)
        {

            x1 = 0f;
            x2 = 0f;

            double discriminant = (b * b) - (4 * a * c);

            if (discriminant > 0)
            {
                x1 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            }

            else if (discriminant == 0)
            {
                x1 = x2 = (-b) / 2 * a;

            }

            else if (discriminant < 0)
            {
                return false;
            }

            return true;
        }

    }
}
