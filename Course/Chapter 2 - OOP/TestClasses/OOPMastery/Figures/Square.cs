using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Figures
{
    public class Square : AFigure
    {
        public Square(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public override double CalculatePerimeter()
        {
            return this.A * 2 + this.B * 2;
        }
    }
}
