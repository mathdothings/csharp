namespace Practice
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();

      var myBankAccout = new BankAccout("John", 500);
      var myExpense = new Expense(-100);

      if (myBankAccout.Money > myExpense.Value && myExpense.Value > 0)
      {
        myBankAccout.Money -= myExpense.Value;
        System.Console.WriteLine
        (
        "### Before Transaction ###" + "\n" +
        $"Name: {myBankAccout.Name}" + "\n" +
        $"Money: {myBankAccout.Money}" + "\n" +
        "### After Transaction ###" + "\n" +
        $"Name: {myBankAccout.Name}" + "\n" +
        $"Money: {myBankAccout.Money}" + "\n"
        );
      }
      else
      {
        System.Console.WriteLine("Invalid transaction!");
      }
    }
  }
}