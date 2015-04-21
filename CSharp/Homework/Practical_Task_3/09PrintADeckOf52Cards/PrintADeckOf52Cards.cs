using System;
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement
//output
//2♣ 2♦ 2♥ 2♠
//3♣ 3♦ 3♥ 3♠
//…
//K♣ K♦ K♥ K♠
//A♣ A♦ A♥ A♠

class PrintADeckOf52Cards
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        for (int row = 0; row < cards.Length; row++)
        {
            for (int suits = 1; suits <= 4; suits++)
            {
                switch (suits)
                {
                    case 1: Console.Write(cards[row] + "♣ "); break;
                    case 2: Console.Write(cards[row] + "♦ "); break;
                    case 3: Console.Write(cards[row] + "♥ "); break;
                    case 4: Console.Write(cards[row] + "♠ "); break;
                }
            }
            Console.WriteLine();
        }
    }
}