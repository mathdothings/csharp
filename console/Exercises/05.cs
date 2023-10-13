namespace StructExercise05;

struct StructNumber { public int n; }
class ClassNumber { public int n; }
class Exercise
{
    public static void ChangeStruct(StructNumber sn) { sn.n = 1; }
    public static void ChangeClass(ClassNumber cn) { cn.n = 2; }
    public static void Answer()
    {
        StructNumber structNumber = new() { n = 10 };
        ClassNumber classNumber = new() { n = 10 };

        ChangeStruct(structNumber);
        ChangeClass(classNumber);

        System.Console.WriteLine(structNumber.n);
        System.Console.WriteLine(classNumber.n);
    }
}