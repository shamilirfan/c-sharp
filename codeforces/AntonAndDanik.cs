using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class AntonAndDanik
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        string b = Console.ReadLine().ToUpper();

        int anton = b.Count(x => "A".Contains(x));
        int danik = b.Count(y => "D".Contains(y));

        if (anton > danik)
        {
            Console.WriteLine($"Anton");
        }
        else if (danik > anton)
        {
            Console.WriteLine($"Danik");
        }
        else
        {
            Console.WriteLine($"Friendship");
        }
    }
}
