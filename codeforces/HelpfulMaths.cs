using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class HelpfulMaths
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine().Replace("+", "");
        var b = a.OrderBy(x => x).ToArray();
        string c = "+";
        int d = 0;

        for (int i = 0; i < a.Length; i += 1)
        {
            d++;
            Console.Write($"{b[i]}");
            if (d > b.Length - 1)
            {
                break;
            }

            Console.Write($"{c}");
        }
    }
}
