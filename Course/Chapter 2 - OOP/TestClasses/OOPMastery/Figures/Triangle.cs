using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Figures
{
    public class Triangle : AFigure
    {
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public override double CalculatePerimeter()
        {
            return this.A + this.B + this.C;
        }

        public override double CalculateArea()
        {
            return (this.A * this.B) / 2;
        }
    }
}
