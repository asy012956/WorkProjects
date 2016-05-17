using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Lambda
{
    public class Lambda
    {
        delegate int del(int i, double b, string c);

        Func<int, double, string, int> someFunction; 

        public Lambda()
        {
            someFunction = (x, y, z) =>
                                    {
                                        //double asd = Math.PI;
                                        double dsa = Math.Sqrt(1);

                                        return x + 5;
                                    };

            someFunction(4, 3, "marto");
           // int j = myDelegate(5, 3.5, "marto"); //j = 25
        }

        public int SomeMethod(int x)
        {
            return x * x;
        }

        public int OtherMethod(int x, double y, string z)
        {
            int asd = 5;
            int dsa = 10;

            return x + (int)y + asd + dsa;
        }




    }




}
