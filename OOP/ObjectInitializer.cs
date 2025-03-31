using System;

// 23
class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
}

class ObjectInitializer
{
    public static void Main(string[] args)
    {
        Student student1 = new Student()
        {
            Name = "Rupa",
            Age = 22,
            Address = "Dhaka"
        };

        Console.WriteLine(
            $"Name: {student1.Name}, Age: {student1.Age}, Address: {student1.Address}"
        );
    }
}
