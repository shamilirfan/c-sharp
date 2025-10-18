using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class AntonAndLetters
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var a = input.Where(char.IsLetter).Distinct();

        Console.WriteLine($"{a.Count()}");
    }
}
