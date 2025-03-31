using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class IQtest
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        string[] b = Console.ReadLine().Split(' ');
        int[] c = new int[b.Length];
        int even = 0;
        int odd = 0;

        for (int i = 0; i < a; i += 1)
        {
            c[i] = int.Parse(b[i]);
        }

        for (int i = 0; i < c.Length; i += 1)
        {
            if (c[i] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }

        for (int i = 0; i < c.Length; i += 1)
        {
            if (even > odd && c[i] % 2 != 0)
            {
                Console.WriteLine($"{i + 1}");
                break;
            }
            else if (odd > even && c[i] % 2 == 0)
            {
                Console.WriteLine($"{i + 1}");
                break;
            }
        }

    }
}