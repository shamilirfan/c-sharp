using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Drinks
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');

        int[] numbers = new int[input.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        double sum = 0;

        for (int x = 0; x < numbers.Length; x++)
        {
            sum += numbers[x];
        }

        Console.WriteLine($"{sum / numbers.Length}");
    }
}
