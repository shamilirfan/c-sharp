using System;
// 9
class Person
{
    public string? name { private get; set; } // auto properties
    public int age { get; private set; }
}
class AutoProperties
{
    public static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.name = "Anis";

        Console.WriteLine($"Age: {person1.age}");

    }
}