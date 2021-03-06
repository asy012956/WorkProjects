﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Abstractions
{
    public class ExtendedBaseClass : IBase
    {
        public int Divide(int a, int b)
        {
            return a % b;
        }

        public int Multiply(int a, int b)
        {
            return a * b * 2;
        }

        public int Subtract(int a, int b)
        {
            return a - b + 1;
        }

        public int Sum(int a, int b)
        {
            return a + b + 2;
        }
    }
}
