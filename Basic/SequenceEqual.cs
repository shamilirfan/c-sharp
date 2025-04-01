class SequenceEqual
{
    public static void Main(string[] args)
    {
        string a = "Hello!", b = "Hello!", c = "!olleH";

        Console.WriteLine($"{a.SequenceEqual(b)}, {a.SequenceEqual(c)}");
    }
}