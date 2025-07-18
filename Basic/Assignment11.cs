using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Assignment11
{
    public static void Main(string[] args)
    {
        string input = "Hello 123 World!";

        int count = input.Count();
        int vowelCount = input.Count(a => "aeiouAEIOU".Contains(a));
        int consonantCount = input.Count(a => char.IsLetter(a) && !"aeiouAEIOU".Contains(a));
        int digitCount = input.Count(char.IsDigit);
        int specialCharacterCount = input.Count(a =>
            !char.IsLetterOrDigit(a) && !char.IsWhiteSpace(a)
        );
        int whiteSpace = input.Count(a => char.IsWhiteSpace(a));
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine($"Count = {count}");
        Console.WriteLine($"Number of vowels: {vowelCount}");
        Console.WriteLine($"Number of consonant: {consonantCount}");
        Console.WriteLine($"Number of digit: {digitCount}");
        Console.WriteLine($"Number of special character: {specialCharacterCount}");
        Console.WriteLine($"Number of whiteSpace: {whiteSpace}");
        Console.WriteLine($"Number of words: {words.Length}");
    }
}
