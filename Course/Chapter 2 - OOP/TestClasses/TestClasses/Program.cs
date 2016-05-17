using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    public class Program
    {
        public delegate int del(int i);

        //public delegate int Adder(int a, int b);

        public static void Main(string[] args)
        {
            //ConstrTest instance = new ConstrTest("Martin");
            //instance.FriendNames.Add("Borko");
            //Console.WriteLine(instance.Age++);

            del myDelegate = x => x * x;
            int j = myDelegate(5);
            Console.WriteLine(j);

            //playing with delegates here:

            //Adder runner = new Adder(SumIntegers);
            //runner += MultiplyIntegers;
            //runner(4, 9);

            //Adder runner2 = new Adder(MultiplyIntegers);
            //Console.WriteLine(runner2(5,10));


        }

        public static int SumIntegers(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
        }

        public static int MultiplyIntegers(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
            return result;
        }
    }
}
