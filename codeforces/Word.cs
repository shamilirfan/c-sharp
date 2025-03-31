using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Word
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        int a = s.Count(char.IsUpper);
        int b = s.Count(char.IsLower);

        if (a > b)
        {
            Console.WriteLine($"{s.ToUpper()}");
        }
        else
        {
            Console.WriteLine($"{s.ToLower()}");
        }

    }
}