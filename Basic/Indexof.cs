using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Indexof
{
    public static void Main(string[] args)
    {

        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

        int indexof = Array.IndexOf(numbers, 3);
        Console.WriteLine($"index of 3 = {indexof}");

    }
}