Menu();

static void Start(int time)
{
  int currentTime = 0;

  while (currentTime != time)
  {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }

  Console.Clear();
  Console.WriteLine("End!");
  Thread.Sleep(500);
  Console.WriteLine("Returning to Menu...");
  Thread.Sleep(1000);
  Menu();
}

static void Menu()
{
  Console.Clear();
  Console.WriteLine("s = seconds => 10s = 10 seconds.");
  Console.WriteLine("m = minutes => 10m = 10 minutes.");
  Console.WriteLine("0 = quit");
  Console.Write("How many time to count: ");

  string input = Console.ReadLine().ToLower();
  char type = Convert.ToChar(input.Substring(input.Length - 1, 1));
  int time = int.Parse(input.Substring(0, input.Length - 1));
  int MULTIPLIER = 1;

  if (type == 'm')
    MULTIPLIER = 60;
  if (time == 0)
    Environment.Exit(0);

  Start(time * MULTIPLIER);
}
