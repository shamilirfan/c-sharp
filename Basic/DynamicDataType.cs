using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.RegularExpressions;

// 25
class DynamicDataType
{
    public static void Main(string[] args)
    {
        dynamic a = 10;
        Console.WriteLine($"{a} is {a.GetType()}");

        a = "Hello";
        Console.WriteLine($"{a} is {a.GetType()}");

        a = 10.55;
        Console.WriteLine($"{a} is {a.GetType()}");

        a = true;
        Console.WriteLine($"{a} is {a.GetType()}");

        a = 'A';
        Console.WriteLine($"{a} is {a.GetType()}");
    }
}
