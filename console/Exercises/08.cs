namespace StructExercise08;

struct MyStruct { public int n; }

class Exercise
{
    public static void Answer()
    {
        MyStruct noNew;
        noNew.n = 0;
        System.Console.WriteLine(noNew.n);
    }
}