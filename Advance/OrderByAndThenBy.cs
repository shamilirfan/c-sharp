class Students
{
    public string? name { get; set; }
    public int age { get; set; }
}

class OrderByAndThenBy
{
    public static void Main(string[] args)
    {
        List<Students> student = new List<Students>
        {
            new Students { name = "John", age = 50 },
            new Students { name = "Bijoy", age = 20 },
            new Students { name = "Himal", age = 45 },
            new Students { name = "Alex", age = 20 },
            new Students { name = "Rupa", age = 40 },
            new Students { name = "Bob", age = 30 },
        };

        var sortedStudents1 = student.OrderBy(a => a.age);
        //// ThenBy for second time sorting
        // var sortedStudents2 = student.OrderBy(a => a.age).ThenBy(a => a.name);

        foreach (var item in sortedStudents1)
        {
            Console.WriteLine($"Name: {item.name}, Age: {item.age}");
        }
    }
}
