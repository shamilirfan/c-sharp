using System;

// 33
public partial class Human
{
    public string? Name { get; set; }
}

public partial class Human
{
    public string? Type { get; set; }
}

class Partial
{
    public static void Main(string[] args)
    {
        Human p1 = new Human();
        p1.Name = "Alice";
        p1.Type = "Human";

        Console.WriteLine($"Name: {p1.Name}, Type: {p1.Type}");
    }
}
