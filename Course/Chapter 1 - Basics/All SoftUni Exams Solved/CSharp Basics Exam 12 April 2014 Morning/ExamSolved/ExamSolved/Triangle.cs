using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Triangle
    {
        public TriangleResult TriangleSolved()
        {
            TriangleResult result = new TriangleResult();
            //input
            int Ax = int.Parse(Console.ReadLine());
            int Ay = int.Parse(Console.ReadLine());
            int Bx = int.Parse(Console.ReadLine());
            int By = int.Parse(Console.ReadLine());
            int Cx = int.Parse(Console.ReadLine());
            int Cy = int.Parse(Console.ReadLine());

            //calculations
            
            //find A to B distance
            double AtoB = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2));

            //find B to C distance
            double BtoC = Math.Sqrt(Math.Pow((Cx - Bx), 2) + Math.Pow((Cy - By), 2));

            //find A to C distance
            double AtoC = Math.Sqrt(Math.Pow((Cx - Ax), 2) + Math.Pow((Cy - Ay), 2));

            //calculate triangle area
            double p = (AtoB + BtoC + AtoC) / 2;
            double area = Math.Sqrt((p * (p - AtoB) * (p - BtoC) * (p - AtoC)));

            //check if a triangle is possible
            if (((AtoB + BtoC) > AtoC) && ((BtoC + AtoC) > AtoB) && ((AtoB + AtoC) > BtoC))
            {
                result.IsTriangle = "Yes";
                result.AreaOrSide = Math.Round(area , 2);
            }
            else
            {
                result.IsTriangle = "No";
                result.AreaOrSide = Math.Round(AtoB, 2);
            }

            return result;
        }
    }
}
