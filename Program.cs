using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
          int coin;
          string userGuess;
          string coinDescription = "Tails";
          Random rng = new Random();

          Console.Write("Enter your guess heads or Tails (H or T)");  
          userGuess = Console.ReadLine();

          coin = rng.Next(0, 2);
          if (coin == 1)
        {
            coinDescription = "Heads";
        }

        if ((coin == 0 && userGuess == "T") || (coin == 1 && userGuess == "H"))
        {
            Console.WriteLine("The coin flip was {0}, you win!", coinDescription);
        }
        else
        {
            Console.WriteLine("The coin flip was {0}, you win!", coinDescription);
        }

        Console.ReadLine();
        }
    }
}