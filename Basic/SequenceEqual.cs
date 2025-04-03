class SequenceEqual
{
    public static void Main(string[] args)
    {
        // 1
        string a = "Hello!", b = "Hello!", c = "!olleH";

        Console.WriteLine($"{a.SequenceEqual(b)}, {a.SequenceEqual(c)}");


        // 2
        char[] a = { 'a', 'b', 'c' };
        char[] b = { 'a', 'b', 'c' };

        bool isEqual_1 = a.SequenceEqual(b);

        Console.WriteLine($"isEqual_1 = {isEqual_1}");


        // 3
        char[] c = { 'a', 'b', 'c' };
        char[] d = { 'd', 'e', 'f' };

        bool isEqual_2 = c.SequenceEqual(d);

        Console.WriteLine($"isEqual_2 = {isEqual_2}");
    }
}