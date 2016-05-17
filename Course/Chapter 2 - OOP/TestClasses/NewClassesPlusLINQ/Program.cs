using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassesPlusLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //IEnumerable<int> myIntegers =
            //    from item in array
            //    where item >= 3
            //    select item;

            //foreach (int item in myIntegers)
            //{
            //    Console.WriteLine(item);
            //}

            Teacher teacher = new Teacher();

            IEnumerable<Student> studentQuery =
                from student in teacher.students
                where student.Scores[0] > 90
                select student;


        }
    }
}
