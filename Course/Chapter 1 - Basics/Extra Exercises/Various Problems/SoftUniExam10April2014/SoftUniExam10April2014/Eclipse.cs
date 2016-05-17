using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExam10April2014
{
    public class Eclipse
    {
        public void PrintEclipse()
        {
            byte N = byte.Parse(Console.ReadLine());

            //print top frame
            string emptyDot = new string(' ', 1);
            string frame = new string('*', (N * 2) - 2);
            string emptyLine = new string(' ', N - 1);
            Console.Write("{0}{1}{2}{3}{4}{5}{6}", emptyDot, frame, emptyDot, emptyLine, emptyDot, frame, emptyDot);
            Console.WriteLine();

            //print top half
            string frameDot = new string('*', 1);
            string lens = new string('/', (N * 2) - 2);
            for (int i = 0; i < ((N / 2) - 1); i++)
            {
                Console.Write("{0}{1}{2}{3}{4}{5}{6}", frameDot, lens, frameDot, emptyLine, frameDot, lens, frameDot);
                Console.WriteLine();
            }

            //print middle line
            string bridge = new string('-', N - 1);
            Console.Write("{0}{1}{2}{3}{4}{5}{6}", frameDot, lens, frameDot, bridge, frameDot, lens, frameDot);
            Console.WriteLine();

            //print bottom half
            for (int i = 0; i < ((N / 2) - 1); i++)
            {
                Console.Write("{0}{1}{2}{3}{4}{5}{6}", frameDot, lens, frameDot, emptyLine, frameDot, lens, frameDot);
                Console.WriteLine();
            }

            //print bottom frame
            Console.Write("{0}{1}{2}{3}{4}{5}{6}", emptyDot, frame, emptyDot, emptyLine, emptyDot, frame, emptyDot);
        }
    }
}
