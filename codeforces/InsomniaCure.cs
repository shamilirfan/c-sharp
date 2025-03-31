using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class InsomniaCure
{
    public static void Main(string[] args)
    {
        int k = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        List<string> list1 = new List<string>();
        int result = 0;

        for (int a = 1; a <= d; a += 1)
        {
            list1.Add(Convert.ToString(a));
        }

        // k
        for (int b = k - 1; b <= d; b += k)
        {
            if (b == list1.Count)
            {
                break;
            }
            list1[b] += "a";
            result++;
        }
        // l
        for (int c = l - 1; c <= d; c += l)
        {
            if (c == list1.Count)
            {
                break;
            }
            if (!list1[c].Contains("a"))
            {
                list1[c] += "b";
                result++;
            }
        }
        // m
        for (int dd = m - 1; dd <= d; dd += m)
        {
            if (dd == list1.Count)
            {
                break;
            }
            if (!list1[dd].Contains("a") && !list1[dd].Contains("b"))
            {
                list1[dd] += "c";
                result++;
            }
        }
        // n
        for (int e = n - 1; e <= d; e += n)
        {
            if (e == list1.Count)
            {
                break;
            }
            if (!list1[e].Contains("a") && !list1[e].Contains("b") && !list1[e].Contains("c"))
            {
                list1[e] += "d";
                result++;
            }
        }

        Console.WriteLine(result);

    }
}