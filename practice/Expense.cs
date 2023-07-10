namespace Practice
{
  public class Expense
  {
    int _value;

    // public int Value { get; set; }

    public int Value
    {
      get { return _value; }
      set { if (value > 0) _value = value; }
    }

    public Expense(int value)
    {
      Value = value;
    }
  }
}