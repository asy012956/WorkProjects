using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Lambda
{
    public class AnonymousTypeDemo
    {
        public AnonymousTypeDemo()
        {
            int a = 5;
            int b = 6;

            var anonymous = new { first = a, second = b };
            //...
        }

        
    }

    public struct NotAnonymous
    {
        public int A { get; set; }

        public int B { get; set; }

        public int C
        {
            get
            {
                return A + B;
            }
        }
    }
}
