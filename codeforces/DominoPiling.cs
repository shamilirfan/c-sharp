using System;

class DominoPiling
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] a = new int[input.Length];

        for (int i = 0; i < input.Length; i += 1)
        {
            a[i] = int.Parse(input[i]);
        }

        int b = a[0] * a[1];
        int c = 2 * 1;

        Console.WriteLine($"{b / c}");

    }
}