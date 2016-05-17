using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class FitBoxInBox
    {
        public void FitBoxInBoxSolved(Box firstBox, Box secondBox)
        {
            //fit first box in second box
            Check(secondBox.Width, secondBox.Height, secondBox.Length, firstBox.Width, firstBox.Height, firstBox.Length);
            Check(secondBox.Width, secondBox.Height, secondBox.Length, firstBox.Width, firstBox.Length, firstBox.Height);
            Check(secondBox.Width, secondBox.Height, secondBox.Length, firstBox.Height, firstBox.Width, firstBox.Length);
            Check(secondBox.Width, secondBox.Height, secondBox.Length, firstBox.Height, firstBox.Length, firstBox.Width);
            Check(secondBox.Width, secondBox.Height, secondBox.Length, firstBox.Length, firstBox.Height, firstBox.Width);
            Check(secondBox.Width, secondBox.Height, secondBox.Length, firstBox.Length, firstBox.Width, firstBox.Height);

            //fit second box in first box
            Check(firstBox.Width, firstBox.Height, firstBox.Length, secondBox.Width, secondBox.Height, secondBox.Length);
            Check(firstBox.Width, firstBox.Height, firstBox.Length, secondBox.Width, secondBox.Length, secondBox.Height);
            Check(firstBox.Width, firstBox.Height, firstBox.Length, secondBox.Length, secondBox.Width, secondBox.Height);
            Check(firstBox.Width, firstBox.Height, firstBox.Length, secondBox.Length, secondBox.Height, secondBox.Width);
            Check(firstBox.Width, firstBox.Height, firstBox.Length, secondBox.Height, secondBox.Length, secondBox.Width);
            Check(firstBox.Width, firstBox.Height, firstBox.Length, secondBox.Height, secondBox.Width, secondBox.Length);
        }

        public void Check(int firstBoxW, int firstBoxH, int firstBoxL, int secondBoxW, int secondBoxH, int secondBoxL)
        {
            if (firstBoxW < secondBoxW && firstBoxH < secondBoxH && firstBoxL < secondBoxL)
            {
                Console.WriteLine("({0},{1},{2}) < ({3},{4},{5})", firstBoxW, firstBoxH, firstBoxL, secondBoxW, secondBoxH, secondBoxL);
            }
        }
    }

    public class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
