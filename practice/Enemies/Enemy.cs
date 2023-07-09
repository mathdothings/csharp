using System.Dynamic;

namespace Enemies
{
  public class Enemy
  {
    public string? Name { get; set; }
    public int CR { get; set; }
    private int HP { get; set; }

    private int CA { get; set; }

    private readonly string[] Subtypes = new string[] { "Dragon", "Orc", "Humanoid" };

    public string? Type { get; set; }

    public Enemy() { }
    public Enemy(string? name)
    {
      Name = name;
    }

    public Enemy(string? name, int cr, int hp, int ca, string? type)
    {
      Name = name;
      CR = cr;
      HP = hp;
      CA = ca;
      foreach (var subtype in Subtypes)
      {
        if (subtype.Equals(type))
        {
          Type = type;
          break;
        }
        else { Type = "None"; }
      }
    }
  }

}