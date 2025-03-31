using System;

class Dubstep
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string a = input.Replace("WUB", " ").TrimStart();

        Console.WriteLine($"{a}");
    }
}