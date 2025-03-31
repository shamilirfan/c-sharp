using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class cAPSLOCK
{
    public static void Main(string[] args)
    {
        string? a = Console.ReadLine();
        int b = a.Count(x => char.IsLower(x));
        int c = a.Count(x => char.IsUpper(x));

        if (char.IsLower(a, 0) && b == 1)
        {
            Console.Write($"{Convert.ToString(a[0]).ToUpper()}");
            for (int i = 1; i < a.Length; i += 1)
            {
                Console.Write($"{Convert.ToString(a[i]).ToLower()}");
            }
        }
        else if (char.IsUpper(a, 0) && b > 1)
        {
            Console.WriteLine($"{a}");
        }
        else if (b == 0)
        {
            Console.WriteLine($"{a.ToLower()}");
        }
        else
        {
            Console.WriteLine($"{a}");
        }

    }
}