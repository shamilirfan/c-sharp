using System;

// 29
class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public static string? City { get; set; }

    public Student(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
}

class Static
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Anika", 20);
        Student.City = "Comilla";

        Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, City: {Student.City}");
    }
}
