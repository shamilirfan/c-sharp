using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class GravityFlip
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int[] b = new int[a];
        string[] c = Console.ReadLine().Split(' ');

        for (int i = 0; i < a; i += 1)
        {
            b[i] = int.Parse(c[i]);
        }

        var g = b.OrderBy(t => t);

        foreach (int item in g)
        {
            Console.Write(item + " ");
        }

    }
}