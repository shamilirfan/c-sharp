using System;
// 8
class Student
{
    private readonly string name = "Linda";
    public readonly int age;
    public Student(int age)
    {
        this.age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class ThisAndReadonly
{
    public static void Main(string[] args)
    {
        Student s1 = new Student(22);
        s1.DisplayInfo();

    }
}