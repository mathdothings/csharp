// See https://aka.ms/new-console-template for more information

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();

      static void Menu()
      {
        Console.Clear();
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1 - Sum");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - Multiply");
        Console.WriteLine("4 - Divide");
        Console.WriteLine("5 - Exit");
        Console.Write("Select an option: ");

        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
          case 1: Sum(); break;
          case 2: Subtract(); break;
          case 3: Multiply(); break;
          case 4: Divide(); break;
          case 5: Environment.Exit(0); break;
        }
      }

      static void Sum()
      {
        Console.Clear();
        Console.WriteLine("First value: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second value: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"Result: {v1 + v2}");
        Console.ReadKey();
        Menu();
      }

      static void Subtract()
      {
        Console.Clear();
        Console.WriteLine("First value: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second value: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"Result: {v1 - v2}");
        Console.ReadKey();
        Menu();
      }

      static void Multiply()
      {
        Console.Clear();
        Console.WriteLine("First value: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second value: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"Result: {v1 * v2}");
        Console.ReadKey();
        Menu();
      }

      static void Divide()
      {
        Console.Clear();
        Console.WriteLine("First value: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second value: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"Result: {v1 / v2}");
        Console.ReadKey();
        Menu();
      }

    }
  }
}