using System;
using System.Reflection;

// 32
class Student
{
    public int? Roll { get; set; }
    public string? Name { get; set; }
    private int? Age { get; set; }

    public string DisplayInfo()
    {
        return $"{Roll}, {Name}, {Age}";
    }
}

class Reflection
{
    public static void Main(string[] args)
    {
        Student student = new Student();

        var methodsType = typeof(Student).GetMethods();

        foreach (var methodType in methodsType)
        {
            Console.WriteLine($"{methodType.ReturnType}, {methodType.Name}");
        }

        var properties = typeof(Student).GetProperties(
            BindingFlags.NonPublic | BindingFlags.Instance
        );
        // .GetProperties();

        foreach (var property in properties)
        {
            Console.WriteLine($"{property.Name}");
        }
    }
}
