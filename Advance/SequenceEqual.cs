using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

class SequenceEqual
{
    public static void Main(string[] args)
    {
        char[] a = { 'a', 'b', 'c' };
        char[] b = { 'a', 'b', 'c' };

        bool isEqual_1 = a.SequenceEqual(b);

        Console.WriteLine($"isEqual_1 = {isEqual_1}");

        //
        char[] c = { 'a', 'b', 'c' };
        char[] d = { 'd', 'e', 'f' };

        bool isEqual_2 = c.SequenceEqual(d);

        Console.WriteLine($"isEqual_2 = {isEqual_2}");

    }
}