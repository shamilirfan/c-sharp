using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ArrayMethods
{
    public static void Main(string[] args)
    {
        int[] numbers1 = new int[5] { 1, 2, 3, 4, 5 };

        Console.WriteLine(numbers1.Max());
        Console.WriteLine(numbers1.Min());
        Console.WriteLine(numbers1.Sum());
        Console.WriteLine(numbers1.Average());


    }
}