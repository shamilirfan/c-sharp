using System;

// 26
class AnonymousType_Object
{
    public static void Main(string[] args)
    {
        var student = new { name = "Rupa", age = 20 };

        Console.WriteLine($"Name: {student.name}, Age: {student.age}");
        Console.WriteLine($"Data Type: {student.GetType()}");
    }
}
