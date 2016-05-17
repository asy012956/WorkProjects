using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Abstractions.Composition
{
    public class ExtendComposit
    {
        private IBase calc;

        public ExtendComposit(IBase calc)
        {
            this.calc = calc;
        }

        public int Sum(int a, int b)
        {
            return this.calc.Sum(a, b);
        }

        public int Subtract(int a, int b)
        {
            return this.calc.Subtract(a, b);
        }

        public int Divide(int a, int b)
        {
            return this.calc.Divide(a, b);
        }

        public int Multiply(int a, int b)
        {
            return this.calc.Multiply(a, b);
        }

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
