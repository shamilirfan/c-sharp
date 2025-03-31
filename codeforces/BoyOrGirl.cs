using System;
using System.Linq;

class BoyOrGirl
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var distinctLetters = input.Where(char.IsLetter).Distinct();
        int count = distinctLetters.Count();

        if (count % 2 == 0)
        {
            Console.WriteLine("CHAT WITH HER!");
        }
        else
        {
            Console.WriteLine("IGNORE HIM!");
        }

    }
}