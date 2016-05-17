using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Task 3a
            Task3 task = new Task3();
            //string result1 = task.GetArrayContentFromFile();
            //Console.WriteLine(result1);
            ////Task 3b
            //int[,] arr = task.ConvertMatrixToIntArray();
            //string result2 = task.ByColumn(arr);
            //Console.WriteLine(result2);

            MartoTask3 mt3 = new MartoTask3();
            int[,] marray = mt3.ConvertMatrixToIntArray();

            string result = task.ByColumn(marray);
            Console.WriteLine(result);

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            mt3.ChangeArray(array);
        }

    }
}
