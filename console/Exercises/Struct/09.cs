using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

namespace StructExercise09;

struct Book
{
    public string? title;
    public string? author;

    public readonly override string ToString() => $"Title: {title}, " +
        $"Author: {author}";

    public Book(string _title, string _author)
    {
        title = _title;
        author = _author;
    }
}

class Exercise
{
    public static void Answer()
    {
        Book[] books = new Book[2];

        for (int i = 0; i < books.Length; i++)
        {
            System.Console.WriteLine("Information of Book #{0}: ", i + 1);
            System.Console.Write("Title: ");
            books[i].title = Console.ReadLine();
            System.Console.Write("Author: ");
            books[i].author = Console.ReadLine();
            System.Console.WriteLine();
        }

        for (int i = 0; i < books.Length; i++)
        {
            System.Console.WriteLine(books[i].ToString());
        }
    }
}