namespace StructExercise07;

struct DefaultAndConstructor
{
    public int n;

    public DefaultAndConstructor(int init) { n = init; }

    public readonly override string ToString() => n.ToString();
}
class Exercise
{
    public static void Answer()
    {
        var myStruct1 = new DefaultAndConstructor(10);
        var myStruct2 = new DefaultAndConstructor();
        System.Console.WriteLine($"By Constructor: {myStruct1}");
        System.Console.WriteLine($"By Default: {myStruct2}");
    }
}