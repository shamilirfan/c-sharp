using System;

class NamedArguments
{
    public static void MyMethod(string child1, string child2, string child3)
    {
        Console.WriteLine("The youngest child is: " + child3);
    }
    public static void Main(string[] args)
    {
        MyMethod(child3: "John", child1: "Liam", child2: "Linda");
    }
}