using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsGraduation
{
    public class Number
    {
        private int number;

        public Number(int number)
        {
            this.number = number;
        }

        public static int operator +(Number numberA, Number numberB)
        {
            return numberA.number + numberB.number;
        }

        public static int operator +(Number numberA, int numberB)
        {
            return numberA.number + numberB;
        }

        public static bool operator ==(Number number, int numberB)
        {
            return number.Equals(numberB);
        }

        public static bool operator !=(Number number, int numberB)
        {
            return false;
        }

        public static int operator !(Number number)
        {
            return number.number * -1;
        }
    }


    public static class Extension
    {
        
    }


}