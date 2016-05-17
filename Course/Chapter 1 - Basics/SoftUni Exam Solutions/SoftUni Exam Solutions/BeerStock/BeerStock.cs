using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeerStock
{
    class BeerStock
    {
        static void Main(string[] args)
        {
            long reservedBeers = long.Parse(Console.ReadLine()); //197
            string beersReceived = Console.ReadLine(); //7 cases
            long totalReceivedBeers = 0;
            double brokenBeers = 0;
            long beersRemaining = 0;
            long cases = 0;
            long sixpacks = 0;
            long beers = 0;
            long missingBeers = 0;

            while (beersReceived != "Exam Over")
            {
                char[] separator = new char[] { ' ' };
                string[] beerDataSplit = beersReceived.Split(separator);
                if (beerDataSplit[1] == "cases")
                {
                    totalReceivedBeers = totalReceivedBeers + Convert.ToInt64(beerDataSplit[0]) * 24;
                    beersReceived = Console.ReadLine();
                }

                else if (beerDataSplit[1] == "sixpacks")
                {
                    totalReceivedBeers = totalReceivedBeers + Convert.ToInt64(beerDataSplit[0]) * 6;
                    beersReceived = Console.ReadLine();
                }

                else if (beerDataSplit[1] == "beers")
                {
                    totalReceivedBeers = totalReceivedBeers + Convert.ToInt64(beerDataSplit[0]) * 1;
                    beersReceived = Console.ReadLine();
                }
            }

            brokenBeers = (double)totalReceivedBeers / 100;
            brokenBeers = Math.Floor(brokenBeers);

            totalReceivedBeers = totalReceivedBeers - (long)brokenBeers;

            if (totalReceivedBeers >= reservedBeers)
            {
                beersRemaining = totalReceivedBeers - reservedBeers; //202
                while (beersRemaining != 0)
                {
                    cases = beersRemaining / 24; // 8
                    beersRemaining = beersRemaining - (cases * 24); //10
                    sixpacks = beersRemaining / 6; //1
                    beersRemaining = beersRemaining - (sixpacks * 6); //4
                    beers = beersRemaining / 1;
                    beersRemaining = beersRemaining - beers;
                }

                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
            }

            else if (totalReceivedBeers < reservedBeers)
            {
                missingBeers = reservedBeers - totalReceivedBeers;

                while (missingBeers != 0)
                {
                    cases = missingBeers / 24;
                    missingBeers = missingBeers - (cases * 24);
                    sixpacks = missingBeers / 6;
                    missingBeers = missingBeers - (sixpacks * 6);
                    beers = missingBeers / 1;
                    missingBeers = missingBeers - beers;
                }

                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
            }
        }
    }
}
