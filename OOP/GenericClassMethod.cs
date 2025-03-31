using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

// 30
class Student<T>
{
    public int? Roll { get; set; }
    public string? Name { get; set; }
    public T? Success { get; set; }

    public string DisplayInfo(Student<T> parameter)
    {
        return $"{parameter.Roll}, {parameter.Name}, {parameter.Success}";
    }
}

class GenericClassMethod
{
    public static void Main(string[] args)
    {
        Student<bool> student1 = new Student<bool>()
        {
            Roll = 1,
            Name = "Himal",
            Success = true
        };

        Console.WriteLine(student1.DisplayInfo(student1));

        Student<int> student2 = new Student<int>()
        {
            Roll = 2,
            Name = "Nowshin",
            Success = 1
        };

        Console.WriteLine(student2.DisplayInfo(student2));
    }
}
