using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Abstractions.Inheritance
{
    public class ChildB : Parent
    {
        public override double Divide(int a, int b)
        {
            return (double)a / (double)b;
        }

        public double Pow(int a, int powBase)
        {
            return Math.Pow(a, powBase);
        }


    }
}
