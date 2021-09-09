using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppBela
{
    class Program
    {
        static void Main(string[] args)
        {

            // Read the hand count and dominant suit
            string handCountAndDominantSuit = Console.ReadLine();


            // Put the number of hands in index 0 and the dominant suit in index 1
            List<string> handCountAndDominantSuitList = new List<string>();
            handCountAndDominantSuitList.AddRange(handCountAndDominantSuit.Split(" "));

            int HandCount = int.Parse(handCountAndDominantSuitList[0]);
            // To make char data type Add zero at end to get char at index 0
            char DominantSuit = handCountAndDominantSuitList[1][0];
            if ((DominantSuit != 'S') && (DominantSuit != 'H') && (DominantSuit != 'D') && (DominantSuit != 'C'))
            {
                Console.WriteLine("Invalid Dominant Suit");
                System.Environment.Exit(0);
            }
            if ((HandCount < 1) || (HandCount > 100))
            {
                Console.WriteLine("Invalid Handcount");
                System.Environment.Exit(0);
            }
            List<string> cardsPlayedList = new List<string>();

            //Each hand has four cards played
            for (int i = 0; i < HandCount * 4; i++)
            {
                //Add to list each card played
                cardsPlayedList.Add(Console.ReadLine());
            }

            int gamePoints = 0;


            // the i is for the index of the list
            //the second index will look at char in index 0 for card number or the char in index 1 for the suit
            for (int i = 0; i < cardsPlayedList.Count; i++)
            {

                if (cardsPlayedList[i][0] == 'A')
                {
                    gamePoints += 11;
                }
                else if (cardsPlayedList[i][0] == 'K')
                {
                    gamePoints += 4;
                }
                else if (cardsPlayedList[i][0] == 'Q')
                {
                    gamePoints += 3;
                }
                else if (cardsPlayedList[i][0] == 'J' && cardsPlayedList[i][1] == DominantSuit)
                {
                    gamePoints += 20;
                }
                else if (cardsPlayedList[i][0] == 'J' && cardsPlayedList[i][1] != DominantSuit)
                {
                    gamePoints += 2;
                }

                else if (cardsPlayedList[i][0] == 'T')
                {
                    gamePoints += 10;
                }

                else if (cardsPlayedList[i][0] == '9' && cardsPlayedList[i][1] == DominantSuit)
                {
                    gamePoints += 14;
                }
                // The ELSE covers the 9 Not Dominant, 8 and 7
                else
                {
                    gamePoints += 0;
                }

            }


            Console.WriteLine(gamePoints);

        }
    }
}
