using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Abstractions.Composition
{
    public class ExtendInherit : BaseClass
    {
        public double Sqrt(int a)
        {
            return Math.Sqrt(a);
        }

        public double Log(int a, int b)
        {
            return Math.Log(a, b);
        }
    }
}
