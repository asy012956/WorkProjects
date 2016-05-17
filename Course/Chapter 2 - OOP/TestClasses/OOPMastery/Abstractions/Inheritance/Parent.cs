using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Abstractions.Inheritance
{
    public abstract class Parent : IParent
    {
        public abstract double Divide(int a, int b);

        public virtual double Multiply(int a, int b)
        {
            return a * b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public string SayHello()
        {
            return "Hello";
        }
    }
}
