using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

// 31
static class Extention
{
    public static string DisplayInfo(this Person person)
    {
        return $"Name: {person.Name}, Age: {person.Age}, City: {person.City}";
    }
}

class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? City { get; set; }
}

class ExtensionMethod
{
    public static void Main(string[] args)
    {
        Person person1 = new Person()
        {
            Name = "Bob",
            Age = 36,
            City = "Berlin"
        };

        Console.WriteLine(person1.DisplayInfo());
    }
}
