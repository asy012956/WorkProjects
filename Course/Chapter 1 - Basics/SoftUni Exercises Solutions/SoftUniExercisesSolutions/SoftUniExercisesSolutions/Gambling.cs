using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExercisesSolutions
{
    public class Gambling
    {
        public void SolveGambling()
        {
            double cash = double.Parse(Console.ReadLine()); //cash used in the game
            string houseHand = Console.ReadLine();
            string[] houseHandArray = houseHand.Split(' ');

            int houseHandStrength = 0;
            int cardStrength = 0;
            double potValue = cash * 2;

            for (int i = 0; i < houseHandArray.Length; i++)
            {
                string card = houseHandArray[i];
                if (card == "2")
                {
                    cardStrength = 2;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "3")
                {
                    cardStrength = 3;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "4")
                {
                    cardStrength = 4;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "5")
                {
                    cardStrength = 5;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "6")
                {
                    cardStrength = 6;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "7")
                {
                    cardStrength = 7;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "8")
                {
                    cardStrength = 8;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "9")
                {
                    cardStrength = 9;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "10")
                {
                    cardStrength = 10;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "J")
                {
                    cardStrength = 11;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "Q")
                {
                    cardStrength = 12;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "K")
                {
                    cardStrength = 13;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else if (card == "A")
                {
                    cardStrength = 14;
                    houseHandStrength = houseHandStrength + cardStrength;
                }
                else
                {
                    throw new Exception("No such card!");
                }
            }

            int allCardCombinations = 0;
            int winningCardCombinations = 0;
            int currentHandStrength = 0;

            for (int card1 = 2; card1 < 15; card1++)
            {
                for (int card2 = 2; card2 < 15; card2++)
                {
                    for (int card3 = 2; card3 < 15; card3++)
                    {
                        for (int card4 = 2; card4 < 15; card4++)
                        {
                            currentHandStrength = card1 + card2 + card3 + card4;
                            allCardCombinations++;
                            if (currentHandStrength > houseHandStrength)
                            {
                                winningCardCombinations++;
                            }
                        }
                    }
                }
            }

            decimal chanceOfWinning = ((decimal)winningCardCombinations / (decimal)allCardCombinations);
            decimal expectedWinnings = Math.Round((chanceOfWinning * (decimal)potValue), 2);
            decimal newChanceOfWinning = chanceOfWinning * 100;

            if (newChanceOfWinning < 50)
            {
                Console.WriteLine("FOLD");
                Console.WriteLine(expectedWinnings);
            }
            else if (newChanceOfWinning >= 50)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(expectedWinnings);
            }
        }
    }
}
