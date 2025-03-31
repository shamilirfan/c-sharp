using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class HQ9+
{
    public static void Main(string[] args)
    {
        string? a = Console.ReadLine();

        int b = a.Count(c => "HQ9".Contains(c));

        if (b > 0)
        {
            Console.WriteLine($"YES");
        }
        else
        {
            Console.WriteLine($"NO");
        }
    }
}