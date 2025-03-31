using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Twins
{
    public static void Main(string[] args)
    {

        int a = int.Parse(Console.ReadLine());
        string[] b = Console.ReadLine().Split();
        int[] c = new int[a];

        for (int i = 0; i < a; i++)
        {
            c[i] = int.Parse(b[i]);
        }


        var d = c.OrderByDescending(a => a).ToArray();
        int e = d.Sum();
        int f = e / 2;

        int sum = 0;
        int counter = 0;

        for (int i = 0; i < a; i++)
        {
            sum += d[i];
            counter++;
            if (sum > f)
            {
                Console.WriteLine($"{counter}");
                break;
            }
        }

    }
}