using System;
using System.Linq;

class IsYourHorseShoeOnTheOtherRoof
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] a = new int[input.Length];
        var b = a.Distinct();

        for (int i = 0; i < input.Length; i += 1)
        {
            a[i] = int.Parse(input[i]);
        }

        var c = b.Count();
        Console.WriteLine($"{a.Length - c}");

    }
}