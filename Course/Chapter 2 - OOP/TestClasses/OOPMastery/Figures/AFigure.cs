using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Figures
{
    public abstract class AFigure : IAreable, IPerimeturable
    {
        public double A { get; set; }

        public double B { get; set; }

        public abstract double CalculatePerimeter();

        public virtual double CalculateArea()
        {
            return this.A * this.B;
        }
    }
}
