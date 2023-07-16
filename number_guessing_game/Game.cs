using System;
using GameMessage;
using GameVerification;
using GamePhase;

namespace Game
{
  public class GuessingGame : IGameMessage, IGameVerification, IGamePhase
  {
    public void StartPhase()
    {
      ShowStartingMessage();
      GuessPhase();
      GuessCheckPhase();
    }
    public void GuessPhase()
    {
      ShowPlayerGuesssingNumber();
    }
    public void GuessCheckPhase()
    {
      ShowGuessResult();
      if (CheckGuessResult()) { FinishPhase(); }
      else { RestartPhase(); }
    }
    public void RestartPhase()
    {
      GuessPhase();
    }
    public void FinishPhase()
    {
      System.Console.WriteLine("Nicely done! You got it!");
    }
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
    static int number = random.Next(0, 100);

    public void ShowNumber()
    {
      System.Console.WriteLine(number);
    }

    public void ShowGuessedNumber()
    {
      System.Console.WriteLine(guessedNumber);
    }

    public void ShowGuessMessage()
    {
      System.Console.Write("Guess a number: ");
    }

    public void ShowGuessResult()
    {
      if (guessedNumber > number) { Console.WriteLine($"{guessedNumber} is too high!"); }
      if (guessedNumber < number) { Console.WriteLine($"{guessedNumber} is too low!"); };
      if (guessedNumber == number) { Console.WriteLine($"{guessedNumber} is equals to {number}"); }
    }

    public bool CheckGuessResult()
    {

      if (guessedNumber > number || guessedNumber < number) { return false; }
      return true;
    }

    static int guessedNumber = int.Parse(Console.ReadLine());
  }
}