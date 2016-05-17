using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Abstractions.Association
{
    public class ClassA
    {
        public int CalculateClassA(ClassB classB)
        {
            return classB.Value * 10;
        }
    }
}
