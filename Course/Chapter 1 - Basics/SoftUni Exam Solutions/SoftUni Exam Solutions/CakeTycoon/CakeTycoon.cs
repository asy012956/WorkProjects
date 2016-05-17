using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class CakeTycoon
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine()); // number of cakes Ivancho wants 500
            decimal c = decimal.Parse(Console.ReadLine()); // kilograms of flour needed to make one cake 0.380
            uint f = uint.Parse(Console.ReadLine()); // kilograms of flour available 800
            uint t = uint.Parse(Console.ReadLine()); // number of truffles available 200
            uint p = uint.Parse(Console.ReadLine()); // price of one truffle 30
            decimal pricePerCake = 0m;

            decimal numberOfCakesPossible = (decimal)f / c;
            uint finalNumberOfCakesPossible = (uint)Math.Floor(numberOfCakesPossible); //2105
            ulong totalTrufflesPrice = (ulong)t * (ulong)p;

            if (finalNumberOfCakesPossible >= n)
            {
                pricePerCake = ((decimal)totalTrufflesPrice / n) * 1.25m;
                Console.WriteLine("All products available, price of a cake: {0:F2}", pricePerCake);
            }

            else if (finalNumberOfCakesPossible < n)
            {
                decimal totalFlourNeeded = (n * c);
                decimal kilogramsOfFlourNeeded = totalFlourNeeded - f;
                Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", finalNumberOfCakesPossible, kilogramsOfFlourNeeded);
            }
        }
    }
}
