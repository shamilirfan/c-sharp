using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ArrayList
{
    public static void Main(string[] args)
    {
        // ArrayList is not type fixed but list is type fixed.
        ArrayList a = new ArrayList { 1, 2, "Hello", "World", 'A', 'B' };

        foreach (var item in a)
        {
            Console.WriteLine($"{item}");
        }

    }
}