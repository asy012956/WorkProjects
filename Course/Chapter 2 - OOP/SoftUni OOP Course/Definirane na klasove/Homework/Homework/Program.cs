using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person firstPerson = new Person("Pesho", 25, "pesho12341@hotmail.com");
            //string aaaa = firstPerson.PrintData();
            //Console.WriteLine(aaaa);

            //Person secondPerson = new Person("Atanas", 42);
            //string asfas = secondPerson.ToString();
            //Console.WriteLine(asfas);

            Laptop myLaptop = new Laptop("Lenovo", 1299.99m);
            string output = myLaptop.ToString();
            Console.WriteLine(output);
        }
    }
}
