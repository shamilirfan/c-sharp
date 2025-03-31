using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class VanyaAndFence
{
    public static void Main(string[] args)
    {
        string[] a = Console.ReadLine().Split(' ');
        int[] b = new int[a.Length];

        for (int c = 0; c < a.Length; c += 1)
        {
            b[c] = int.Parse(a[c]);
        }

        //
        string[] d = Console.ReadLine().Split(' ');
        int[] e = new int[b[0]];
        int f = 0;

        for (int g = 0; g < b[0]; g += 1)
        {
            e[g] = int.Parse(d[g]);
        }

        for (int h = 0; h < b[0]; h += 1)
        {
            if (e[h] <= b[1])
            {
                f += 1;
            }
            else
            {
                f += 2;
            }
        }

        Console.WriteLine($"{f}");

    }
}