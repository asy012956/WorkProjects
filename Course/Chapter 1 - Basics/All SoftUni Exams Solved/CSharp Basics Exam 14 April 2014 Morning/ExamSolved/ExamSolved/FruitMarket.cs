using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class FruitMarket
    {
        public void FruitMarketSolved()
        {
            string dayOfWeek = Console.ReadLine();
            decimal product1Quantity = decimal.Parse(Console.ReadLine());
            string product1Name = Console.ReadLine();
            decimal product2Quantity = decimal.Parse(Console.ReadLine());
            string product2Name = Console.ReadLine();
            decimal product3Quantity = decimal.Parse(Console.ReadLine());
            string product3Name = Console.ReadLine();

            decimal bananaPrice = 1.8m;
            decimal cucumberPrice = 2.75m;
            decimal tomatoPrice = 3.2m;
            decimal orangePrice = 1.6m;
            decimal applePrice = 0.86m;
            decimal mid1Price = 0m;
            decimal mid2Price = 0m;
            decimal mid3Price = 0m;

            decimal totalPrice = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Saturday")
            {
                if (product1Name == "banana")
                {
                    mid1Price = product1Quantity * bananaPrice;
                }
                else if (product1Name == "cucumber")
                {
                    mid1Price = product1Quantity * cucumberPrice;
                }
                else if (product1Name == "tomato")
                {
                    mid1Price = product1Quantity * tomatoPrice;
                }
                else if (product1Name == "orange")
                {
                    mid1Price = product1Quantity * orangePrice;
                }
                else if (product1Name == "apple")
                {
                    mid1Price = product1Quantity * applePrice;
                }

                //---------------------------------

                if (product2Name == "banana")
                {
                    mid2Price = product2Quantity * bananaPrice;
                }
                else if (product2Name == "cucumber")
                {
                    mid2Price = product2Quantity * cucumberPrice;
                }
                else if (product2Name == "tomato")
                {
                    mid2Price = product2Quantity * tomatoPrice;
                }
                else if (product2Name == "orange")
                {
                    mid2Price = product2Quantity * orangePrice;
                }
                else if (product2Name == "apple")
                {
                    mid2Price = product2Quantity * applePrice;
                }

                //--------------------------------

                if (product3Name == "banana")
                {
                    mid3Price = product3Quantity * bananaPrice;
                }
                else if (product3Name == "cucumber")
                {
                    mid3Price = product3Quantity * cucumberPrice;
                }
                else if (product3Name == "tomato")
                {
                    mid3Price = product3Quantity * tomatoPrice;
                }
                else if (product3Name == "orange")
                {
                    mid3Price = product3Quantity * orangePrice;
                }
                else if (product3Name == "apple")
                {
                    mid3Price = product3Quantity * applePrice;
                }

                totalPrice = mid1Price + mid2Price + mid3Price;
                Console.WriteLine("{0:F2}", totalPrice); 
            }

            if (dayOfWeek == "Tuesday")
            {
                if (product1Name == "banana")
                {
                    mid1Price = (product1Quantity * bananaPrice) * 0.8m;
                }
                else if (product1Name == "cucumber")
                {
                    mid1Price = product1Quantity * cucumberPrice;
                }
                else if (product1Name == "tomato")
                {
                    mid1Price = product1Quantity * tomatoPrice;
                }
                else if (product1Name == "orange")
                {
                    mid1Price = (product1Quantity * orangePrice) * 0.8m;
                }
                else if (product1Name == "apple")
                {
                    mid1Price = (product1Quantity * applePrice) * 0.8m;
                }

                //---------------------------------

                if (product2Name == "banana")
                {
                    mid2Price = (product2Quantity * bananaPrice) * 0.8m;
                }
                else if (product2Name == "cucumber")
                {
                    mid2Price = product2Quantity * cucumberPrice;
                }
                else if (product2Name == "tomato")
                {
                    mid2Price = product2Quantity * tomatoPrice;
                }
                else if (product2Name == "orange")
                {
                    mid2Price = (product2Quantity * orangePrice) * 0.8m;
                }
                else if (product2Name == "apple")
                {
                    mid2Price = (product2Quantity * applePrice) * 0.8m;
                }

                //--------------------------------

                if (product3Name == "banana")
                {
                    mid3Price = (product3Quantity * bananaPrice) * 0.8m;
                }
                else if (product3Name == "cucumber")
                {
                    mid3Price = product3Quantity * cucumberPrice;
                }
                else if (product3Name == "tomato")
                {
                    mid3Price = product3Quantity * tomatoPrice;
                }
                else if (product3Name == "orange")
                {
                    mid3Price = (product3Quantity * orangePrice) * 0.8m;
                }
                else if (product3Name == "apple")
                {
                    mid3Price = (product3Quantity * applePrice) * 0.8m;
                }

                totalPrice = mid1Price + mid2Price + mid3Price;
                Console.WriteLine("{0:F2}", totalPrice);
            }

            if (dayOfWeek == "Wednesday")
            {
                if (product1Name == "banana")
                {
                    mid1Price = product1Quantity * bananaPrice;
                }
                else if (product1Name == "cucumber")
                {
                    mid1Price = (product1Quantity * cucumberPrice) * 0.9m;
                }
                else if (product1Name == "tomato")
                {
                    mid1Price = (product1Quantity * tomatoPrice) * 0.9m;
                }
                else if (product1Name == "orange")
                {
                    mid1Price = product1Quantity * orangePrice;
                }
                else if (product1Name == "apple")
                {
                    mid1Price = product1Quantity * applePrice;
                }

                //---------------------------------

                if (product2Name == "banana")
                {
                    mid2Price = product2Quantity * bananaPrice;
                }
                else if (product2Name == "cucumber")
                {
                    mid2Price = (product2Quantity * cucumberPrice) * 0.9m;
                }
                else if (product2Name == "tomato")
                {
                    mid2Price = (product2Quantity * tomatoPrice) * 0.9m;
                }
                else if (product2Name == "orange")
                {
                    mid2Price = product2Quantity * orangePrice;
                }
                else if (product2Name == "apple")
                {
                    mid2Price = product2Quantity * applePrice;
                }

                //--------------------------------

                if (product3Name == "banana")
                {
                    mid3Price = product3Quantity * bananaPrice;
                }
                else if (product3Name == "cucumber")
                {
                    mid3Price = (product3Quantity * cucumberPrice) * 0.9m;
                }
                else if (product3Name == "tomato")
                {
                    mid3Price = (product3Quantity * tomatoPrice) * 0.9m;
                }
                else if (product3Name == "orange")
                {
                    mid3Price = product3Quantity * orangePrice;
                }
                else if (product3Name == "apple")
                {
                    mid3Price = product3Quantity * applePrice;
                }

                totalPrice = mid1Price + mid2Price + mid3Price;
                Console.WriteLine("{0:F2}", totalPrice);
            }

            if (dayOfWeek == "Thursday")
            {
                if (product1Name == "banana")
                {
                    mid1Price = (product1Quantity * bananaPrice) * 0.7m;
                }
                else if (product1Name == "cucumber")
                {
                    mid1Price = product1Quantity * cucumberPrice;
                }
                else if (product1Name == "tomato")
                {
                    mid1Price = product1Quantity * tomatoPrice;
                }
                else if (product1Name == "orange")
                {
                    mid1Price = product1Quantity * orangePrice;
                }
                else if (product1Name == "apple")
                {
                    mid1Price = product1Quantity * applePrice;
                }

                //---------------------------------

                if (product2Name == "banana")
                {
                    mid2Price = (product2Quantity * bananaPrice) * 0.7m;
                }
                else if (product2Name == "cucumber")
                {
                    mid2Price = product2Quantity * cucumberPrice;
                }
                else if (product2Name == "tomato")
                {
                    mid2Price = product2Quantity * tomatoPrice;
                }
                else if (product2Name == "orange")
                {
                    mid2Price = product2Quantity * orangePrice;
                }
                else if (product2Name == "apple")
                {
                    mid2Price = product2Quantity * applePrice;
                }

                //--------------------------------

                if (product3Name == "banana")
                {
                    mid3Price = (product3Quantity * bananaPrice) * 0.7m;
                }
                else if (product3Name == "cucumber")
                {
                    mid3Price = product3Quantity * cucumberPrice;
                }
                else if (product3Name == "tomato")
                {
                    mid3Price = product3Quantity * tomatoPrice;
                }
                else if (product3Name == "orange")
                {
                    mid3Price = product3Quantity * orangePrice;
                }
                else if (product3Name == "apple")
                {
                    mid3Price = product3Quantity * applePrice;
                }

                totalPrice = mid1Price + mid2Price + mid3Price;
                Console.WriteLine("{0:F2}", totalPrice);
            }

            if (dayOfWeek == "Friday")
            {
                if (product1Name == "banana")
                {
                    mid1Price = (product1Quantity * bananaPrice) * 0.9m;
                }
                else if (product1Name == "cucumber")
                {
                    mid1Price = (product1Quantity * cucumberPrice) * 0.9m;
                }
                else if (product1Name == "tomato")
                {
                    mid1Price = (product1Quantity * tomatoPrice) * 0.9m;
                }
                else if (product1Name == "orange")
                {
                    mid1Price = (product1Quantity * orangePrice) * 0.9m;
                }
                else if (product1Name == "apple")
                {
                    mid1Price = (product1Quantity * applePrice) * 0.9m;
                }

                //---------------------------------

                if (product2Name == "banana")
                {
                    mid2Price = (product2Quantity * bananaPrice) * 0.9m;
                }
                else if (product2Name == "cucumber")
                {
                    mid2Price = (product2Quantity * cucumberPrice) * 0.9m;
                }
                else if (product2Name == "tomato")
                {
                    mid2Price = (product2Quantity * tomatoPrice) * 0.9m;
                }
                else if (product2Name == "orange")
                {
                    mid2Price = (product2Quantity * orangePrice) * 0.9m;
                }
                else if (product2Name == "apple")
                {
                    mid2Price = (product2Quantity * applePrice) * 0.9m;
                }

                //--------------------------------

                if (product3Name == "banana")
                {
                    mid3Price = (product3Quantity * bananaPrice) * 0.9m;
                }
                else if (product3Name == "cucumber")
                {
                    mid3Price = (product3Quantity * cucumberPrice) * 0.9m;
                }
                else if (product3Name == "tomato")
                {
                    mid3Price = (product3Quantity * tomatoPrice) * 0.9m;
                }
                else if (product3Name == "orange")
                {
                    mid3Price = (product3Quantity * orangePrice) * 0.9m;
                }
                else if (product3Name == "apple")
                {
                    mid3Price = (product3Quantity * applePrice) * 0.9m;
                }

                totalPrice = mid1Price + mid2Price + mid3Price;
                Console.WriteLine("{0:F2}", totalPrice);
            }

            if (dayOfWeek == "Sunday")
            {
                if (product1Name == "banana")
                {
                    mid1Price = (product1Quantity * bananaPrice) * 0.95m;
                }
                else if (product1Name == "cucumber")
                {
                    mid1Price = (product1Quantity * cucumberPrice) * 0.95m;
                }
                else if (product1Name == "tomato")
                {
                    mid1Price = (product1Quantity * tomatoPrice) * 0.95m;
                }
                else if (product1Name == "orange")
                {
                    mid1Price = (product1Quantity * orangePrice) * 0.95m;
                }
                else if (product1Name == "apple")
                {
                    mid1Price = (product1Quantity * applePrice) * 0.95m;
                }

                //---------------------------------

                if (product2Name == "banana")
                {
                    mid2Price = (product2Quantity * bananaPrice) * 0.95m;
                }
                else if (product2Name == "cucumber")
                {
                    mid2Price = (product2Quantity * cucumberPrice) * 0.95m;
                }
                else if (product2Name == "tomato")
                {
                    mid2Price = (product2Quantity * tomatoPrice) * 0.95m;
                }
                else if (product2Name == "orange")
                {
                    mid2Price = (product2Quantity * orangePrice) * 0.95m;
                }
                else if (product2Name == "apple")
                {
                    mid2Price = (product2Quantity * applePrice) * 0.95m;
                }

                //--------------------------------

                if (product3Name == "banana")
                {
                    mid3Price = (product3Quantity * bananaPrice) * 0.95m;
                }
                else if (product3Name == "cucumber")
                {
                    mid3Price = (product3Quantity * cucumberPrice) * 0.95m;
                }
                else if (product3Name == "tomato")
                {
                    mid3Price = (product3Quantity * tomatoPrice) * 0.95m;
                }
                else if (product3Name == "orange")
                {
                    mid3Price = (product3Quantity * orangePrice) * 0.95m;
                }
                else if (product3Name == "apple")
                {
                    mid3Price = (product3Quantity * applePrice) * 0.95m;
                }

                totalPrice = mid1Price + mid2Price + mid3Price;
                Console.WriteLine("{0:F2}", totalPrice);
            }
        }
    }
}
