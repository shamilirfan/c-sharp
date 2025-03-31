using System;

class Student
{
    public string? name { get; set; }
    public int age { get; set; }
    public string? city { get; set; }
}
class SelectObj
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student{name = "Alex", age = 30, city = "Khulna"},
            new Student{name = "Bob", age = 45, city = "Dhaka"},
            new Student{name = "Rupa", age = 20, city = "Comilla"},
            new Student{name = "Himal", age = 18, city = "Savar"},
            new Student{name = "Shiwly", age = 25, city = "Dhaka"}
        };

        var names1 = students.Select(y => y.name);

        foreach (var item in names1)
        {
            Console.WriteLine($"Name: {item}");
        }



        // use of tuple
        var names2 = students.Select(a => (a.name, a.city));

        foreach (var item in names2)
        {
            Console.WriteLine($"Name: {item.name}, City: {item.city}");
        }



    }
}







