using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Clear
{
    public static void Main(string[] args)
    {
        int[] a = new int[5] { 1, 2, 3, 4, 5 };
        int[] b = new int[a.Length];

        Array.Copy(a, b, a.Length);
        Array.Clear(b, 0, b.Length);

        foreach (int c in b)
        {
            Console.Write($"{c} ");
        }


    }
}