using OOPMastery.Abstractions.Inheritance;
using OOPMastery.Figures;
using OOPMastery.Generics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using OOPMastery.ExtensionMethods;
using OOPMastery.Abstractions.Composition;
using OOPMastery.Abstractions;

namespace OOPMastery
{
    public class Program 
    {
        static void Main(string[] args)
        {
            #region MList
            //MList<int> myList = new MList<int>();
            //int element = 0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    element = int.Parse(Console.ReadLine());
            //    myList.Add(element);
            //}

            //int maxElement = myList.Max();
            //Console.Write(maxElement + " ");
            //int minElement = myList.Min();
            //Console.Write(minElement + " ");
            //int firstElement = myList.First(n => n % 2 == 0);
            //Console.Write(firstElement + " ");
            //int firstElement2 = myList.First(n => n % 3 == 0);
            //Console.Write(firstElement2 + " ");
            //int lastElement = myList.Last(n => n % 2 == 0);
            //Console.Write(lastElement + " ");

            //var whereElements = myList.Where(n => n % 2 == 0);

            //foreach (var item in whereElements)
            //{
            //    Console.Write(item + " ");
            //}

            //var specialElements = myList.Where(n => n % 7 == 0 && n % 10 != 1);

            //foreach (var item in whereElements)
            //{
            //    Console.Write(item + " ");
            //}

            //var newSpecialElement = myList.Last(n => n % 10 == 7); //last element in row ending in 7
            //element = myList.Max();

            //////

            ////var ne6toSI = myList.Position((el, pos) => el == pos);
            //ExtendInherit calc = new ExtendInherit();

            //ExtendComposit exc = new ExtendComposit(new BaseClass());

            //Console.WriteLine(exc.Sum(5, 9));
            //Console.WriteLine(exc.Multiply(11, 3));

            //ExtendComposit exC2 = new ExtendComposit(new ExtendedBaseClass());
            //Console.WriteLine(exC2.Sum(5, 9));
            //Console.WriteLine(exC2.Multiply(11, 3));
            #endregion

            //create linked list
            MLinkedList<int> myLinkedList = new MLinkedList<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    myLinkedList.Add(i);
                }
            }

            foreach (int member in myLinkedList)
            {
                Console.Write(member + " ");
            }

            Console.WriteLine();

            //add new element to linked list
            //myLinkedList.Add(7);

            //foreach(int member in myLinkedList)
            //{
            //    Console.Write(member + " ");
            //}

            //Console.WriteLine();

            ////count all elements in linked list
            //Console.WriteLine(myLinkedList.Count);

            //insert new element in linked list
            //myLinkedList.Insert(11, 4);

            //foreach (int member in myLinkedList)
            //{
            //    Console.Write(member + " ");
            //}

            //Console.WriteLine();

            //remove element in linked list
            //myLinkedList.Remove(11);
            //foreach (int member in myLinkedList)
            //{
            //    Console.Write(member + " ");
            //}

            //Console.WriteLine();

            //myLinkedList.Remove(7);
            //foreach (int member in myLinkedList)
            //{
            //    Console.Write(member + " ");
            //}
            //Console.WriteLine();

            myLinkedList.Remove(0); //????
            foreach (int member in myLinkedList)
            {
                Console.Write(member + " ");
            }
            Console.WriteLine();

            //myLinkedList.Insert(600, 4);
            //foreach (int member in myLinkedList)
            //{
            //    Console.Write(member + " ");
            //}
            //Console.WriteLine();

            //myLinkedList.Insert(7000, 0);
            //foreach (int member in myLinkedList)
            //{
            //    Console.Write(member + " ");
            //}
            //Console.WriteLine();
        }
    }
}
