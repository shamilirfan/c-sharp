using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Exists
{
    public static void Main(string[] args)
    {
        int[] numbers1 = new int[5] { 5, 1, 3, 2, 4 };
        int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };

        bool exists1 = Array.Exists(numbers2, number => number == 5);
        bool exists2 = Array.Exists(numbers2, number => number == 6);

        Console.WriteLine($"{exists1}");
        Console.WriteLine($"{exists2}");
    }
}
