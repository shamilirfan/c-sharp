using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class CodeforcesChecking
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < a; i += 1)
        {
            string? b = Console.ReadLine();

            if (b == "c" || b == "o" || b == "d" || b == "e" || b == "f" || b == "o" || b == "r" ||
            b == "c" || b == "e" || b == "s")
            {
                Console.WriteLine($"YES");
            }
            else
            {
                Console.WriteLine($"NO");
            }
        }

    }
}