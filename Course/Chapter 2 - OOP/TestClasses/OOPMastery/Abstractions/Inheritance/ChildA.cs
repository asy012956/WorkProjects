using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Abstractions.Inheritance
{
    public class ChildA : Parent
    {
        public override double Divide(int a, int b)
        {
            return a / b;
        }
    }
}
