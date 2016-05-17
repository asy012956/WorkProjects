using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ExamSolved
{
    public class Tribonacci
    {
        public BigInteger TribonacciSolved(BigInteger num1, BigInteger num2, BigInteger num3, BigInteger N)
        {
            if (N == 1)
            {
                return num1;
            }
            else if (N == 2)
            {
                return num2;
            }
            else if (N == 3)
            {
                return num3;
            }
            else
            {
                BigInteger numNew = 0;
                for (int i = 3; i < N; i++)
                {
                    numNew = num3 + num2 + num1;
                    num1 = num2;
                    num2 = num3;
                    num3 = numNew;
                }

                return numNew;
            }
        }
    }
}
