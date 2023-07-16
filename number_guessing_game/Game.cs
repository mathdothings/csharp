using System;
using GameMessage;

namespace Game
{
  public class GuessingGame : IGameMessage
  {
    public void ShowStartingMessage()
    {
      System.Console.WriteLine("Welcome to the Number Guessing Game!");
      System.Console.WriteLine("To win the game, just try to guess what is the correct number, between 1 and 100, that the computer was recorded on it's memory.");
    }

    public void ShowPlayerGuesssingNumber()
    {
      System.Console.WriteLine("Please, type a number between 1 and 100: ");
    }

    public void ShowIncorrectGuessedNumber()
    {
      System.Console.WriteLine("That's not the correct number.");
    }

    static Random random = new();
    int number = random.Next(0, 100);

    public int ShowNumber() { return number; }
  }
}