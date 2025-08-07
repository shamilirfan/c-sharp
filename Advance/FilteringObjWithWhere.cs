using System;

class Student
{
    public string name { get; set; }
    public int age { get; set; }
}

class FilteringObjWithWhere
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { name = "Alex", age = 30 },
            new Student { name = "Bob", age = 45 },
            new Student { name = "Rupa", age = 20 },
            new Student { name = "Himal", age = 18 },
            new Student { name = "Shiwly", age = 25 },
        };

        // filtering
        var a = students.Where(student => student.age > 25);

        foreach (var item in a)
        {
            Console.WriteLine($"Name: {item.name}, Age: {item.age}");
        }
    }
}
