Console.Clear();
var gameMode = Mode.Hard;

System.Console.WriteLine((Mode)gameMode);
System.Console.WriteLine(gameMode.ToString());
System.Console.WriteLine((int)gameMode);
System.Console.WriteLine((int)gameMode);

string test = "Normal";
Mode getMode;
bool _ = Enum.TryParse(test, out getMode);
System.Console.WriteLine(getMode);

enum Mode
{
    Easy = 1,
    Normal = 3,
    Hard = 5
}

class Monster
{
    Mode GameMode = Mode.Normal;
    public int Attack { get; set; } = 1;
    public int Defense { get; set; } = 1;
    public string? Name { get; set; }
    public int Scale { get; set; } = 3;

    public Monster(int scale)
    {
        Attack *= scale;
        Defense *= scale;
    }
}