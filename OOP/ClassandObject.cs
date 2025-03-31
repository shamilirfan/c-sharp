using System;
// 1
class Person
{
    public string name;
    public int age;
}
class Fruit
{
    public string name;
    public string color;
    public int price;
}
class ClassAndObject
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Alex";
        p1.age = 33;
        Console.WriteLine($"Name: {p1.name}, Age: {p1.age}");

        Person p2 = new Person();
        p2.name = "Bob";
        p2.age = 20;
        Console.WriteLine($"Name: {p2.name}, Age: {p2.age}\n");

        Fruit apple = new Fruit();
        apple.name = "Apple";
        apple.color = "Green";
        apple.price = 320;
        Console.WriteLine($"Fruit: {apple.name}, Color: {apple.color}, Price: {apple.price}");

    }
}