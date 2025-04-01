using System.Text;

class StringBuilder
{
    public static void Main(string[] args)
    {
        StringBuilder a = new StringBuilder();
        a.Append("Hello!");

        Console.WriteLine(a);
        Console.WriteLine(a.ToString().Reverse().ToArray());
    }
}