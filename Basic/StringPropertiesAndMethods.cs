using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class StringPropertiesAndMethods
{
    public static void Main(string[] args)
    {
        string a = "Hello Everyone!";

        // Length
        Console.WriteLine($"Length of string: {a.Length}");

        // ToUpper()
        Console.WriteLine($"string at upperCase: {a.ToUpper()}");

        // ToLower()
        Console.WriteLine($"string at lowerCase: {a.ToLower()}");

        // index from string
        Console.WriteLine($"0 index from string: {a[0]}");


        // IsNullOrEmpty()
        string b = "";
        bool c = string.IsNullOrEmpty(b);

        Console.WriteLine($"Is string null or empty?: {c}");


        // Trim()
        string d = " Hi ";
        Console.WriteLine($"Trim = {d.Trim()}");
        Console.WriteLine($"TrimStart = {d.TrimStart()}");
        Console.WriteLine($"TrimEnd = {d.TrimEnd()}");

        // Substring()
        string substring = "Hello Bangladesh!";
        Console.WriteLine($"Substring with single paramiter = {substring.Substring(6)}");
        Console.WriteLine($"Substring with multiple paramiter = {substring.Substring(6, 10)}");


        // Insert()
        string insert = "Insert!";
        Console.WriteLine($"Insert = {insert.Insert(0, "Hi ")}");


        // Remove()
        string remove = "Hello Remove";
        Console.WriteLine($"Remove = {remove.Remove(4)}");


        // Replace()
        Console.WriteLine($"Replace = {remove.Replace("Remove", "Replace!")}");


        // Contains()
        Console.WriteLine($"Contains = {remove.Contains("Hello")}");
        Console.WriteLine($"Contains = {remove.Contains("World")}");


        // Reverse()
        string reverse = "Bangladesh";
        Console.WriteLine($"Reverse = {new string(reverse.Reverse().ToArray())}");




    }
}