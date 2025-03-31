using System;

// 20
interface IInformation
{
    string GetBasicInformation();
}

public class Course : IInformation
{
    public int CourseID { get; set; }
    public string? CourseName { get; set; }
    public int CourseDuration { get; set; }

    public Course(int CourseID, string CourseName, int CourseDuration)
    {
        this.CourseID = CourseID;
        this.CourseName = CourseName;
        this.CourseDuration = CourseDuration;
    }

    public string GetBasicInformation()
    {
        return $"Course Id: {CourseID}, Course Name: {CourseName}, Course Duration: {CourseDuration} months";
    }
}

public class Department : IInformation
{
    public int DepartmentID { get; set; }
    public string? DepartmentName { get; set; }

    public Department(int DepartmentID, string DepartmentName)
    {
        Students = new List<Student>();
        Courses = new List<Course>();
        this.DepartmentID = DepartmentID;
        this.DepartmentName = DepartmentName;
    }

    public List<Student> Students { get; set; }
    public List<Course> Courses { get; set; }

    public string GetBasicInformation()
    {
        return $"Department Id: {DepartmentID}, Department Name: {DepartmentName}";
    }
}

public class Student : IInformation
{
    public int StudentRoll { get; set; }
    public int StudentReg { get; set; }
    public string? StudentName { get; set; }

    public Student(int StudentRoll, int StudentReg, string StudentName)
    {
        this.StudentRoll = StudentRoll;
        this.StudentReg = StudentReg;
        this.StudentName = StudentName;
    }

    public string GetBasicInformation()
    {
        return $"Roll: {StudentRoll}, Reg: {StudentReg}, Name: {StudentName}";
    }
}

class Interface
{
    public static void Main(string[] args)
    {
        Student student = new Student(1, 4357, "Anika");
        Console.WriteLine($"{student.GetBasicInformation()}");

        Department department = new Department(101, "CSE");
        Console.WriteLine($"{department.GetBasicInformation()}");

        Course course = new Course(1, "C++", 3);
        Console.WriteLine(course.GetBasicInformation());
    }
}
