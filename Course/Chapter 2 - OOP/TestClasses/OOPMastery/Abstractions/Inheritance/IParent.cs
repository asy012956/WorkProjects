using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Abstractions.Inheritance
{
    public interface IParent
    {
        int Sum(int a, int b);
        double Multiply(int a, int b);
        double Divide(int a, int b);
    }
}
