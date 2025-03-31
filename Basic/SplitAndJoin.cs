using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class SplitAndJoin
{
    public static void Main(string[] args)
    {
        string a = "Hello Bangladesh! you are so beautiful";
        // split()
        var b = a.Split(' ');

        foreach (var item in b)
        {
            Console.WriteLine($"{item}");
        }

        // string.Join()
        Console.WriteLine($"Join = {string.Join(", ", b)}");



    }
}