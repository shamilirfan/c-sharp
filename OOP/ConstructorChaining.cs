using System;
// 11
class Person
{
    public string? firstName { get; set; }
    public string? middleName { get; set; }
    public string? lastName { get; set; }

    public Person(string firstName, string middleName, string lastName) : this(firstName, lastName)
    {
        this.middleName = middleName;
    }
    public Person(string firstName, string lastName) : this(firstName)
    {
        this.lastName = lastName;
    }
    public Person(string firstName)
    {
        this.firstName = firstName;
    }
}
class ConstructorChaining
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("MD", "Anisul", "Islam");
        Person person2 = new Person("SK", "Himal");
        Person person3 = new Person("Shagor");

        Console.WriteLine($"{person1.firstName} {person1.middleName} {person1.lastName}");
        Console.WriteLine($"{person2.firstName} {person2.lastName}");
        Console.WriteLine($"{person3.firstName}");

    }

}