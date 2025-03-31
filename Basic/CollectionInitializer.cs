using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

// 24
class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class CollectionInitializer
{
    public static void Main(string[] args)
    {
        Student student1 = new Student() { Name = "Rupa", Age = 18 };
        Student student2 = new Student() { Name = "Mahim", Age = 20 };

        List<Student> students = new List<Student>() { student1, student2 };

        foreach (Student student in students)
        {
            Console.WriteLine($"{student.Name} is {student.Age} years old.");
        }
    }
}
