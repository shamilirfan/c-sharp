using System;
// 10
class Person
{
    public string? firstName { get; set; }
    public string? middleName { get; set; }
    public string? lastName { get; set; }
    public Person(string firstName, string middleName, string lastName)
    {
        this.firstName = firstName;
        this.middleName = middleName;
        this.lastName = lastName;
    }
    // Constructor Overloading. It is means everything is same but parameter is diffrent.
    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}
class ConstructorOverloading
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("MD", "Anisul", "Islam");
        Person person2 = new Person("SK", "Himal");

        Console.WriteLine($"{person1.firstName} {person1.middleName} {person1.lastName}");
        Console.WriteLine($"{person2.firstName} {person2.lastName}");

    }
}