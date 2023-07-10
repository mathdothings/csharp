namespace Practice
{
  public class BankAccout
  {
    int money;
    string? name;

    public int Money
    {
      get { return money; }
      set { money = value; }
    }

    public string? Name { get { return name; } set { name = value; } }

    public BankAccout(string? walletName, int startingMoney)
    {
      name = walletName;
      money = startingMoney;
    }

    public BankAccout(int startingMoney)
    {
      money = startingMoney;
    }
  }
}
