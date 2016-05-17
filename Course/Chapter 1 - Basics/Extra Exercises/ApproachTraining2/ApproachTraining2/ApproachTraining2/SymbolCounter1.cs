using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachTraining2
{
    class SymbolCounter1
    {
        public void SymbolCounter()
        {
            string input = Console.ReadLine();
            int[] capitals = new int[26];
            int[] smallLetters = new int[26];
            int[] numbers = new int[10];

            int countA = input.Length - input.Replace("A", "").Length;
            int countB = input.Length - input.Replace("B", "").Length;
            int countC = input.Length - input.Replace("C", "").Length;
            int countD = input.Length - input.Replace("D", "").Length;
            int countE = input.Length - input.Replace("E", "").Length;
            int countF = input.Length - input.Replace("F", "").Length;
            int countG = input.Length - input.Replace("G", "").Length;
            int countH = input.Length - input.Replace("H", "").Length;
            int countI = input.Length - input.Replace("I", "").Length;
            int countJ = input.Length - input.Replace("J", "").Length;
            int countK = input.Length - input.Replace("K", "").Length;
            int countL = input.Length - input.Replace("L", "").Length;
            int countM = input.Length - input.Replace("M", "").Length;
            int countN = input.Length - input.Replace("N", "").Length;
            int countO = input.Length - input.Replace("O", "").Length;
            int countP = input.Length - input.Replace("P", "").Length;
            int countQ = input.Length - input.Replace("Q", "").Length;
            int countR = input.Length - input.Replace("R", "").Length;
            int countS = input.Length - input.Replace("S", "").Length;
            int countT = input.Length - input.Replace("T", "").Length;
            int countU = input.Length - input.Replace("U", "").Length;
            int countV = input.Length - input.Replace("V", "").Length;
            int countW = input.Length - input.Replace("W", "").Length;
            int countX = input.Length - input.Replace("X", "").Length;
            int countY = input.Length - input.Replace("Y", "").Length;
            int countZ = input.Length - input.Replace("Z", "").Length;

            int counta = input.Length - input.Replace("a", "").Length;
            int countb = input.Length - input.Replace("b", "").Length;
            int countc = input.Length - input.Replace("c", "").Length;
            int countd = input.Length - input.Replace("d", "").Length;
            int counte = input.Length - input.Replace("e", "").Length;
            int countf = input.Length - input.Replace("f", "").Length;
            int countg = input.Length - input.Replace("g", "").Length;
            int counth = input.Length - input.Replace("h", "").Length;
            int counti = input.Length - input.Replace("i", "").Length;
            int countj = input.Length - input.Replace("j", "").Length;
            int countk = input.Length - input.Replace("k", "").Length;
            int countl = input.Length - input.Replace("l", "").Length;
            int countm = input.Length - input.Replace("m", "").Length;
            int countn = input.Length - input.Replace("n", "").Length;
            int counto = input.Length - input.Replace("o", "").Length;
            int countp = input.Length - input.Replace("p", "").Length;
            int countq = input.Length - input.Replace("q", "").Length;
            int countr = input.Length - input.Replace("r", "").Length;
            int counts = input.Length - input.Replace("s", "").Length;
            int countt = input.Length - input.Replace("t", "").Length;
            int countu = input.Length - input.Replace("u", "").Length;
            int countv = input.Length - input.Replace("v", "").Length;
            int countw = input.Length - input.Replace("w", "").Length;
            int countx = input.Length - input.Replace("x", "").Length;
            int county = input.Length - input.Replace("y", "").Length;
            int countz = input.Length - input.Replace("z", "").Length;

            Console.WriteLine("A = {0}", countA);
            Console.WriteLine("B = {0}", countB);
            Console.WriteLine("C = {0}", countC);
            Console.WriteLine("D = {0}", countD);
            Console.WriteLine("E = {0}", countE);
            Console.WriteLine("F = {0}", countF);
            Console.WriteLine("G = {0}", countG);
            Console.WriteLine("H = {0}", countH);
            Console.WriteLine("I = {0}", countI);
            Console.WriteLine("J = {0}", countJ);
            Console.WriteLine("K = {0}", countK);
            Console.WriteLine("L = {0}", countL);
            Console.WriteLine("M = {0}", countM);
            Console.WriteLine("N = {0}", countN);
            Console.WriteLine("O = {0}", countO);
            Console.WriteLine("P = {0}", countP);
            Console.WriteLine("Q = {0}", countQ);
            Console.WriteLine("R = {0}", countR);
            Console.WriteLine("S = {0}", countS);
            Console.WriteLine("T = {0}", countT);
            Console.WriteLine("U = {0}", countU);
            Console.WriteLine("V = {0}", countV);
            Console.WriteLine("W = {0}", countW);
            Console.WriteLine("X = {0}", countX);
            Console.WriteLine("Y = {0}", countY);
            Console.WriteLine("Z = {0}", countZ);

            Console.WriteLine("a = {0}", counta);
            Console.WriteLine("b = {0}", countb);
            Console.WriteLine("c = {0}", countc);
            Console.WriteLine("d = {0}", countd);
            Console.WriteLine("e = {0}", counte);
            Console.WriteLine("f = {0}", countf);
            Console.WriteLine("g = {0}", countg);
            Console.WriteLine("h = {0}", counth);
            Console.WriteLine("i = {0}", counti);
            Console.WriteLine("j = {0}", countj);
            Console.WriteLine("k = {0}", countk);
            Console.WriteLine("l = {0}", countl);
            Console.WriteLine("m = {0}", countm);
            Console.WriteLine("n = {0}", countn);
            Console.WriteLine("o = {0}", counto);
            Console.WriteLine("p = {0}", countp);
            Console.WriteLine("q = {0}", countq);
            Console.WriteLine("r = {0}", countr);
            Console.WriteLine("s = {0}", counts);
            Console.WriteLine("t = {0}", countt);
            Console.WriteLine("u = {0}", countu);
            Console.WriteLine("v = {0}", countv);
            Console.WriteLine("w = {0}", countw);
            Console.WriteLine("x = {0}", countx);
            Console.WriteLine("y = {0}", county);
            Console.WriteLine("z = {0}", countz);

            //Console.WriteLine(input);
        }
    }
}
