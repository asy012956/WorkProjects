using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsGraduation
{
    class Program
    {
        //daden n,
        //da se izvedat vsi4ki prosti 4isla do n, i sumite mejdu tqh i nai blizkoto 4islo delimo na 5
        static void Main(string[] args)
        {
            Women w = new Women();
            w.GraduationDate = DateTime.Today;
            w.GraduationDateString = "11/02/2017";
            Console.WriteLine(w.GraduationDateString);


            for (int i = 1; i < 105; i++)
            {
                w.Age++;
                Console.WriteLine(w.IsAlive);
            }
        }
    }
}
