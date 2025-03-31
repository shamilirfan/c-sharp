using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class UltraFastMathematician
{
    public static void Main(string[] args)
    {
        string? a = Console.ReadLine();
        string? b = Console.ReadLine();
        char[] c = a.ToCharArray();
        char[] d = b.ToCharArray();

        for (int e = 0; e < c.Length; e += 1)
        {
            if (c[e] != d[e])
            {
                Console.Write($"1");
            }
            else
            {
                Console.Write($"0");
            }
        }

    }
}