using System.Runtime.CompilerServices;

namespace StructExercise06;

struct Mine
{
    public int MyProperty { get; set; }
    int myField = 10;
    public readonly string MyMethod() => $"Field: {myField} Property: {MyProperty}";

    public Mine()
    {
        MyProperty = 10;
    }

    public readonly override string ToString()
    {
        return $"MyProperty: {MyProperty}\n" +
            $"myField: {myField}\n" +
            $"MyMethod: {MyMethod}";
    }
}

public class Exercise
{
    public static void Answer()
    {
        var mine = new Mine().ToString();
        System.Console.WriteLine(mine);
    }
}