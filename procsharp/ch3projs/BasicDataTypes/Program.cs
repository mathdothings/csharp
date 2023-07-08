// See https://aka.ms/new-console-template for more information
Console.WriteLine("***** Fun with Basic Data Types *****");
// LocalVarDeclarations();
// DefaultDeclarations();
// ParseFromStringsWithTryParse();
TryParseString();

static void LocalVarDeclarations()
{
  Console.WriteLine("=> Data Declarations:");
  // Local variables are declared and initialized as follows:
  // dataType varName = initialValue;
  int myInt = 0;
  string myString;
  myString = "This is my character data";
  // Declare 3 bools on a single line.
  bool b1 = true, b2 = false, b3 = b1;
  // Use System.Boolean data type to declare a bool.
  System.Boolean b4 = false;
  Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
    myInt, myString, b1, b2, b3, b4);
  Console.WriteLine();
}

static void DefaultDeclarations()
{
  Console.WriteLine("=> Default Declarations:");
  int myInt = default;
  // int i = new();
  Console.WriteLine(myInt);
}

static void ParseFromStringsWithTryParse()
{
  Console.WriteLine("=> Data type parsing with TryParse:");
  if (bool.TryParse("True", out bool b))
  {
    Console.WriteLine("Value of b: {0}", b);
  }
  else
  {
    Console.WriteLine("Default value of b: {0}", b);
  }

  string value = "Hello";
  if (double.TryParse(value, out double d))
  {
    Console.WriteLine("Value of d: {0}", d);
  }
  else
  {
    Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value, d);

  }
  Console.WriteLine();
}

static void TryParseString()
{
  string value = "Done";
  bool result = bool.TryParse(value, out bool b);
  System.Console.WriteLine(result);
}