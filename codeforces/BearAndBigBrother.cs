using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class BearAndBigBrother
{
    public static void Main(string[] args)
    {
        string[] a = Console.ReadLine().Split(' ');
        int b = int.Parse(a[0]);
        int c = int.Parse(a[1]);
        int result = 0;

        for (int i = 0; i < c; i += 1)
        {
            result++;
            b *= 3;
            c *= 2;
            if (b > c)
            {
                break;
            }
        }

        Console.WriteLine($"{result}");

    }
}