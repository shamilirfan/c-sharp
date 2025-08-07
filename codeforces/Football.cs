using System;

class Football
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string a = input.Contains("1111111") || input.Contains("0000000") ? "YES" : "NO";
        Console.WriteLine($"{a}");
    }
}
