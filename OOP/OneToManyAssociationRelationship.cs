using System;

// 13
class Department
{
    public int DepartmentID { get; set; }
    public string? DepartmentName { get; set; }
    public List<Course> Courses { get; set; }
    public Department(int DepartmentID, string DepartmentName)
    {
        Courses = new List<Course>();
        this.DepartmentID = DepartmentID;
        this.DepartmentName = DepartmentName;
    }
    public string DisplayInfo()
    {
        string info = $"{Environment.NewLine}Department Name: {DepartmentName}";
        foreach (Course course in Courses)
        {
            info += $"{Environment.NewLine}Course ID: {course.CourseID}{Environment.NewLine}Course Name: {course.CourseName}{Environment.NewLine}Duration: {course.CourseDuration} months";
        }
        return info;
    }
}
class Course
{
    public int CourseID { get; set; }
    public string? CourseName { get; set; }
    public int? CourseDuration { get; set; }
    public Course(int CourseID, string CourseName, int CourseDuration)
    {
        this.CourseID = CourseID;
        this.CourseName = CourseName;
        this.CourseDuration = CourseDuration;
    }
}
class Students
{
    public int Roll { get; set; }
    public string? Name { get; set; }
    public Students(int roll, string name)
    {
        this.Roll = roll;
        this.Name = name;
    }
    public string DisplayInfo() => $"{Environment.NewLine}Roll: {Roll}{Environment.NewLine}Name: {Name}";
}

class OneToManyAssociationRelationship
{
    public static void Main(string[] args)
    {
        // Course
        Course course1 = new Course(1, "C#", 2);
        Course course2 = new Course(2, "Python", 3);
        Course course3 = new Course(3, "Computer Networking", 6);

        // Department
        Department department1 = new Department(1, "CSE");
        Department department2 = new Department(2, "EEE");
        department1.Courses.Add(course1);
        department1.Courses.Add(course2);
        department2.Courses.Add(course3);

        // Students
        Students students1 = new Students(1, "Bob");
        Students students2 = new Students(2, "Nowshin");

        // Print Info
        Console.WriteLine($"{students1.DisplayInfo()}{department1.DisplayInfo()}");
        Console.WriteLine($"{students2.DisplayInfo()}{department2.DisplayInfo()}");
        Console.WriteLine();

    }
}