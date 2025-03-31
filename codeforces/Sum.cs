using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Sum
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());

        for (int i = 0; i < a; i += 1)
        {
            List<string> b = new List<string>(Console.ReadLine().Split(' '));
            List<int> c = b.Select(int.Parse).ToList();

            for (int d = 0; d < c.Count(); d += 1)
            {
                if (c[0] + c[2] == c[1] || c[0] + c[1] == c[2] || c[0] == c[1] + c[2])
                {
                    Console.WriteLine($"YES");
                    break;
                }
                else
                {
                    Console.WriteLine($"NO");
                    break;
                }
            }
        }

    }
}