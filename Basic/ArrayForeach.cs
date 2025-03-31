using System;

class ArrayForeach
{
    public static void Main(string[] args)
    {
        string[] names;
        names = new string[5] { "Alex", "Sathi", "Rupa", "Bob", "Topu" };

        foreach (string name in names)
        {
            Console.WriteLine($"{name}");
        }

    }
}