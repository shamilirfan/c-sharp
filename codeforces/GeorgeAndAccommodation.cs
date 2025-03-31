using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class GeorgeAndAccommodation
{
    public static void Main(string[] args)
    {

        int a = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 0; i < a; i++)
        {
            string[] b = Console.ReadLine().Split(' ');
            int c = int.Parse(b[0]);
            int d = int.Parse(b[1]);

            if (c < d - 1)
            {
                result++;
            }
        }

        Console.WriteLine($"{result}");

    }
}