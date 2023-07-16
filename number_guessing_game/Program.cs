using Game;

namespace NumberGuessingGame
{
  public static class Program
  {
    public static void Main(string[] args)
    {
      Console.Clear();
      var game = new GuessingGame();
      game.ShowStartingMessage();
      System.Console.WriteLine(game.ShowNumber());
    }
  }
}