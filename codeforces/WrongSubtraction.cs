using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class WrongSubtraction
{
    public static void Main(string[] args)
    {
        // A value's Last digit 0 or others digit, the rules of finding out that :-  
        // n % 10 = 0 then last digit 0 else last digit not 0.

        string[] a = Console.ReadLine().Split(' ');
        int b = int.Parse(a[0]);
        int c = int.Parse(a[1]);

        for (int i = 0; i < c; i++)
        {
            if (b % 10 == 0)
            {
                b /= 10;
            }
            else
            {
                b--;
            }
        }

        Console.WriteLine($"{b}");

    }
}