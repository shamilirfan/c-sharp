using System;

class Student
{
    public string? Name { get; set; }
    public string? City { get; set; }
    public int Age { get; set; }
    public Student(string Name, string City, int Age)
    {
        this.Name = Name;
        this.City = City;
        this.Age = Age;
    }
}
class AnyAndAll
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>{
             new Student("Nowshin", "Dhaka", 26),
             new Student("Himal", "Sylhet", 22),
             new Student("Ripon", "Khulna", 46),
             new Student("Alice", "Savar", 57),
             new Student("Rumaly", "Comilla", 18)
        };

        bool adultStudents = students.All(a => a.Age >= 20);
        Console.WriteLine($"Are all student adults? {adultStudents}");

        bool teenagerStudents = students.Any(a => a.Age < 20);
        Console.WriteLine($"Is there any teenager? {teenagerStudents}");

        bool contain = students.Select(a => a.Name).Contains("Alice");
        Console.WriteLine($"{contain}");

    }
}

