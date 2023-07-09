namespace Enemies
{
  public class Dragon : Enemy
  {
    public new int CR { get; set; } = 5;

    public Dragon() { }

    public Dragon(string? name)
    {
      Name = name;
    }

    public Dragon(string? name, int cr)
    {
      Name = name;
      CR = cr;
    }
  }
}
