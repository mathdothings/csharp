using Enemies;

namespace Practice
{
  public class Program
  {
    public static void Main()
    {

      var orc = new Enemy("Orc Warrior", 1, 30, 14, "Orc");
      System.Console.WriteLine($"Name: {orc.Name}\nType: {orc.Type}");

      // var dragon = new Dragon("Smaug", 15);
      // System.Console.WriteLine($"{dragon.Name} {dragon.CR}");
    }
  }
}