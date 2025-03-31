using System;
// 5
class Person
{
    private string? name;
    private int age;
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class Encapsulation
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Bob";
        p1.age = 32;
        p1.DisplayInfo();

    }
}